using System;
using System.ComponentModel.Design;

namespace annagram
{



    class Program
    {
        public static void FindAnagram(string word1, string word2) //using keyvalue pair algorithm
        {
            Dictionary<char, int> wrd1 = new Dictionary<char, int>();
            Dictionary<char, int> wrd2 = new Dictionary<char, int>();

            for (int i = 0; i < word1.Length; i++)
            {


                if (wrd1.ContainsKey(word1[i]))
                {
                    int temp = wrd1[word1[i]];
                    wrd1[word1[i]] = ++temp;

                }
                else
                {
                    wrd1.Add(word1[i], 1);
                }

            }
            for (int i = 0; i < word2.Length; i++)
            {

                if (wrd2.ContainsKey(word2[i]))
                {
                    int temp = wrd1[word2[i]];
                    wrd2[word2[i]] = ++temp;

                }
                else
                {
                    wrd2.Add(word2[i], 1);
                }

            }

            for (int i = 0; i < word1.Length; i++)
            {
                if (wrd1[word1[i]] == wrd2[word1[i]])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("not a anagram");
                   
                    return;
                }
            }
            Console.WriteLine("anagram");



        }
        public static void Main(string[]args)
        {

            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            var len1=word1.Length;
            var len2=word2.Length;
            if (len1 != len2)
            {
                Console.WriteLine("not a anagram");
                return;
            }

            FindAnagram(word1, word2);
            char[] wrd1Arr = word1.ToCharArray();
            char[] wrd2Arr = word2.ToCharArray();
            Array.Sort(wrd1Arr);
            Array.Sort(wrd2Arr);

            for (int i = 0; i < len1; i++)
            {
                if (wrd1Arr[i] == wrd2Arr[i])
                    continue;
                else
                    Console.WriteLine("not a anagram");
                return;

                

            }
            Console.WriteLine("anagram");

            Console.ReadKey();



        }
    }
}
