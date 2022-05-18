using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDisplay;

namespace TICTACTOE
{
    public class CheckWinner
    {
        public static bool IsRowWinner(int[,] ticTacToe,int Row,int Coloumn,int player)
        {
            var count = 0;
            
            for (int i = Coloumn; i>=0 ; i--)
            {
                if (ticTacToe[Row, i] == player)
                {
                    count++;
                }
            }

            for (int i = Coloumn+1; i < 3 ; i++)
            {
                if (ticTacToe[Row, i] == player)
                {
                    count++;
                }

            }

            
            if (count==3)
            {
                return true;
            }
            else
            {

                return false;
            }


        }

        public static bool IsColoumnWinner(int[,] ticTactoe, int Row, int Coloumn,int player)
        {
            var count = 0;
            for (int i = Row ; i >= 0; i--)
            {
                if (ticTactoe[i, Coloumn] == player)
                    count++;
            }

            for (int i = Row+1; i <3 ; i++)
            {

                if(ticTactoe[i, Coloumn] == player)
                    count++;
            }
            

            if (count==3)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public static void PlayerChance(int player,int row,int col)
        {
            Console.Clear();
            switch (player)
            {
                case 1:
                    Graphical_user_interface.PrintMapper(player, row,col);
                    Console.WriteLine("playe 1 this is your chance");
                    break;
                case 0:
                    Graphical_user_interface.PrintMapper(player, row, col);
                    Console.WriteLine("player 2 this is your chance");
                    break;
            }
        }

        public static bool IsWinMain(int[,] ticTacToe, int Row, int Coloumn,int player)
        {
            var count = 0;
            int i = Row ;
            int j = Coloumn ;
            for (;(i >= 0 && j >= 0); i--,j--)
            {
                if (ticTacToe[i, j] == player)
                {
                    count++;
                }

            }
            int i1 = Row + 1;
            int j1 = Coloumn + 1;
            for (; (i1 < 3 && j1 < 3); i1++, j1++)
            {
                if (ticTacToe[i1, j1] == player)
                {
                    count++;
                }

            }

            if (count == 3)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public static bool IsWinCross(int[,] ticTacToe, int row, int coloumn,int player)
        {
            var count = 0;
            int i = row ;
            int j = coloumn ;
            for (; (i >= 0 && j < 3); i--, j++)
            {
                if (ticTacToe[i, j] == player)
                {
                    count++;
                }

            }
            int i1 = row + 1;
            int j1 = coloumn - 1;
            for (; (i1 < 3 && j1 >=0); i1++, j1--)
            {
                if (ticTacToe[i1, j1] == player)
                {
                    count++;
                }

            }

            if (count == 3)
            {
                return true;
            }
            else
            {

                return false;
            }





        }

        public static void PrintWinner(int player)
        {
            Console.Clear();
            if (player == 0)
            {
                Console.WriteLine("player 2 is the winner");
            }else if (player==1)
            {

                Console.WriteLine("player 1 is the winner");
            }


        }


        public static void Validateinput(int[,] ticTacToe, int row, int col)
        {
            if (ticTacToe[row, col] == 0 || ticTacToe[row, col] == 1)
                throw new Exception("antha edathula erkanave number iruku ");
            
        }
    }
}
