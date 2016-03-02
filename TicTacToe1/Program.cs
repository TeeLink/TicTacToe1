using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

            char currentPlayer = 'x';

            while (true)
            {


                Console.WriteLine("{0} | {1} | {2}", board[0], board[1], board[2]);
                Console.WriteLine("---------------");
                Console.WriteLine("{0} | {1} | {2}", board[3], board[4], board[5]);
                Console.WriteLine("---------------");
                Console.WriteLine("{0} | {1} | {2}", board[6], board[7], board[8]);

                Console.WriteLine($"Player {currentPlayer}, it's your turn!");
                string userInput = Console.ReadLine();
                var move = int.Parse(userInput);
                board[move] = currentPlayer;

                ///attempt at ai randomized turn

                Random turn = new Random();
                int robotTurn = turn.Next(0, 8);
                string robotInput = robotTurn;
                if (currentPlayer == 'o')
                {
                    move = (robotTurn);
                }

                ///attempt at ai randomized turn

                if ((board[0] == currentPlayer) && (board[1] == currentPlayer) && (board[2] == currentPlayer))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");

                }
                if ((board[3] == currentPlayer) && (board[4] == currentPlayer) && (board[5] == currentPlayer))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    break;
                }
                if ((board[6] == currentPlayer) && (board[7] == currentPlayer) && (board[8] == currentPlayer))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    break;
                }
                if ((board[0] == currentPlayer) && (board[3] == currentPlayer) && (board[6] == currentPlayer))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    break;
                }
                if ((board[1] == currentPlayer) && (board[4] == currentPlayer) && (board[7] == currentPlayer))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    break;
                }
                if ((board[2] == currentPlayer) && (board[5] == currentPlayer) && (board[8] == currentPlayer))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    break;
                }
                if ((board[0] == currentPlayer) && (board[4] == currentPlayer) && (board[8] == currentPlayer))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    break;
                }
                if ((board[2] == currentPlayer) && (board[4] == currentPlayer) && (board[6] == currentPlayer))
                {
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    break;
                }
                bool isFull = true;
                foreach (var spot in board)

                    if (spot != 'x' && spot != 'o') ;
                {
                    isFull = false;
                    break;
                    
                }

                if(isFull=true)
                {
                    Console.WriteLine("TIE");

                }




                if (currentPlayer == 'x')
                {
                    currentPlayer = 'o';
                }
                else
                {
                    currentPlayer = 'x';
                }



                Console.Clear();



            }
        }
    }
}

