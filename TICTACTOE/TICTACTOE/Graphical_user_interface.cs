using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using inputStream;

namespace ConsoleDisplay
{
    public partial class Graphical_user_interface
    {
        static char[] ContainsElements = new char[9];
        private static int count = 0;

        public char this[char index]
        {
            get
            {
                if (ContainsElements[index] == 0)
                {
                    return ' ';
                }

                return ContainsElements[index];
            }
            set { }
        }

        public static void GameTitle()
        {

            for (int i = 0; i < 40; i++) Console.Write(" ");
            for (int i = 0; i < 22; i++) Console.Write("--");
            Console.WriteLine();
            for (int i = 0; i < 44; i++) Console.Write(" ");


            Console.WriteLine("WELCOME TO TICTACTOE");

            Console.WriteLine();
            for (int i = 0; i < 40; i++) Console.Write(" ");
            for (int i = 0; i < 22; i++) Console.Write("--");
            Console.WriteLine();
            new Graphical_user_interface().ShowInstruction();



        }
    }
    public partial class Graphical_user_interface
    {
    private void ShowInstruction()
        {
            Console.WriteLine("KINDLY ENTER THE INPUT IN THE FOLLOWING FORMAT ");
            Console.WriteLine();
            Console.WriteLine($"  00  |  01   | 02 ");
            Console.WriteLine("_______________________");
            Console.WriteLine($"  10  |  11   | 12 ");
            Console.WriteLine("_______________________");
            Console.WriteLine($"  20  |  21   | 22 ");

        }

        public static int GetGametype()
        {
            int userInput;
            Console.Clear();
            Console.WriteLine("Choose mode...");
            Console.WriteLine(@"press 1 for Single player mode");
            Console.WriteLine(@"press 2 for Single player mode");

            userInput =Convert.ToInt16( Console.ReadLine());
            if (userInput == 1 || userInput == 2)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("enter valid number");
                Console.ReadKey();
                 userInput=GetGametype();
                 return userInput;

            }



        }  

        public static void PrintMapper(int player, int row ,int col)
        {
            var symbol = (player == 1) ? 'O' : 'X';   // here values for player 1 and player two are inverted because we are displaying previous players result in current players chance 
            var input = $"{row}{col}";
            if (count == 0)
            {
                count++;
                goto endl;
            }
             
            switch (input)
            {
                case "00": ContainsElements[0] = symbol;
                    break;
                    
                case "01": ContainsElements[1]= symbol;
                    break;
                    
                case "02": ContainsElements[2]= symbol;
                    break;

                case "10":ContainsElements[3]= symbol;
                    break;
                    
                case "11":ContainsElements[4]= symbol;
                    break;
                    
                case "12":ContainsElements[5]= symbol;
                    break;
                    
                case "20":ContainsElements[6] = symbol;
                    break;
                    
                case "21":ContainsElements[7]= symbol;
                    break;
                    
                case "22":ContainsElements[8] = symbol;
                    break;
                    
            }
             new Graphical_user_interface().PrintTicTacToe();
             endl:;

        }




        private  void PrintTicTacToe()
        {
            Console.WriteLine($"  {ContainsElements[0]}  |  {ContainsElements[1]}   | {ContainsElements[2]} ");
            Console.WriteLine("_______________________");
            Console.WriteLine($"  {ContainsElements[3]}  |  {ContainsElements[4]}   | {ContainsElements[5]} ");
            Console.WriteLine("_______________________");
            Console.WriteLine($"  {ContainsElements[6]}  |  {ContainsElements[7]}   | {ContainsElements[8]} ");
        }

        public static bool RetryingAsker()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Do YOU WISH TO retry ?????? \n      yes : to continue\n      No: to return");
             var userResponse=Console.ReadLine();
             if (userResponse == "yes") return true;
             else if(userResponse== "no") return false;
             else {

                 Console.WriteLine("please type correct response ");
                 return RetryingAsker();
             }

        }
    }
}
