using FbConsoleApk.App_data.Repository;
using FbConsoleApk.Model;
using FbConsoleApk.View;

namespace FbConsoleApk.Controller
{
    public class PostController 
    {
        public static void UploadNewPost(string userUniqueId,string userName)
        {
        
            var newPost = PostDisplayer.GetPostDetails(userUniqueId,userName);       //getting new post from user(view classes)
        
            PostDisplayer.PrintPost(newPost);
            LikeDisplayer.PrintLikeCmtCount(LikeDataHandler.GetLikeCount(newPost.PostUniqueId),CommentsDataHandler.GetCommentCount(newPost.PostUniqueId));

            PostDataHandler.AddPost(newPost);                                         //Adding new post to repository 
            switch (PostDisplayer.AfterAddPostAction())
            {
                case 1:
                    UserController.RedirectToSignIn();
                    return;
                case 2:
                    UserController.RedirectToProfile(userUniqueId);
                    return;
                case 3:
                    MapWithUserReaction(userUniqueId, userName,newPost.PostUniqueId);
                    return;
            }
        }

        private static void MapWithUserReaction(string userUniqueId, string userName,string postUniqueId)
        {
            if (LikeDataHandler.UserReactionExist(userUniqueId, postUniqueId))
            {
                switch (LikeDisplayer.AlreadyLikeExist())
                {
                    case 1:
                        UserController.RedirectToProfile(userUniqueId);
                        return;
                    case 2:
                        UserController.RedirectToSignIn();
                        return;

                }

            }

            var newReaction = new LikesMapper 
            {
                UniqueId = userUniqueId,
                UserName = userName,
                PostUniqueId = postUniqueId,
                UserReaction = (Reaction)LikeDisplayer.GetUserReaction()
            };
            
            LikeDataHandler.AddLikes(newReaction);
            UserController.RedirectToProfile(userUniqueId);
        }

        public static void PeerUserPost(User client) 
        {
            var postsObj = new PostDataHandler();
            var userPosts = postsObj.GetUserPost(client.UniqueId);
            foreach (var post in userPosts)
            {
                cycle:
                PostDisplayer.PrintPost(post);
                
                LikeDisplayer.PrintLikeCmtCount(LikeDataHandler.GetLikeCount(post.PostUniqueId),CommentsDataHandler.GetCommentCount(post.PostUniqueId));
                switch (PostDisplayer.ViewPostUserAction())
                {
                    case 1:
                        UserController.RedirectToSignIn();
                        return;
                    case 2: break;

                    case 3:
                        LikeDisplayer.PrintPostLikes(LikeDataHandler.FetchUserLikesDetails(post.PostUniqueId));
                        switch (LikeDisplayer.AfterLikesUserChoice())
                        {
                            case 1:
                                UserController.RedirectToSignIn();
                                return;
                            case 2: break;
                            case 3:
                                CommentController.PrintPostComments(post);
                                goto cycle;
                            case 4:
                                UserController.RedirectToProfile(post.UserUniqueId);
                                return;
                            case 5: goto cycle;
                        }

                        break;
                    case 4:
                        CommentController.PrintPostComments(post);
                        switch (CommentDisplayer.AfterCmtsUserChoice())
                        {
                            case 1:
                                UserController.RedirectToSignIn();
                                return;
                            case 2:
                                UserController.RedirectToProfile(post.UserUniqueId);
                                return;
                            case 3: break;

                            case 4:
                                LikeDisplayer.PrintPostLikes(LikeDataHandler.FetchUserLikesDetails(post.PostUniqueId));
                                goto cycle;

                            case 5: goto cycle;
                        }

                        break;
                    case 5:
                        UserController.RedirectToProfile(client.UniqueId);
                        return;
                    case 6: MapWithUserReaction(post.UserUniqueId,post.UserName,post.PostUniqueId);
                        return;
                }
            }

            UserController.RedirectToProfile(client.UniqueId);
        }
    }
}
