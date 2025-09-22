using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiden_WhileLoops_GameProgramming1
{
    internal class Program
    {
        static bool keepGuessing = false;
        static bool gameStarted;
        static int NumToGuess;

        static Random GenerateNumber = new Random();

        static void RandomNumber()
        {
            NumToGuess = GenerateNumber.Next(101);
            Console.WriteLine("You Can Now Begin To Guess!");
            keepGuessing = true;
            PressAny();
        }

        static void PressAny()
        {
            Console.WriteLine("\nPress Any Key...");
            Console.ReadKey();
            Console.Clear();
        }
        static void PrintStart()
        {
            Console.WriteLine("Welcome to the higher or lower game!");
            PressAny();
            gameStarted = true;
        }

        static void GuessNumber()
        {

        }


        static void Main(string[] args)
        {
            PrintStart();

            while(gameStarted)
            {

                RandomNumber();

                while(keepGuessing)
                {



                }

            }
        }
    }
}
