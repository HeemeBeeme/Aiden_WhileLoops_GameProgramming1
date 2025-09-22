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
        static bool writeIntro = true;
        static bool endGame = false;
        static int NumToGuess;
        static int PlayerNum;
        static string PlayerInput;

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
            writeIntro = false;
        }

        static void GuessNumber()
        {
            Console.WriteLine("Your Guess is: ");
            Console.SetCursorPosition(16,0);
            PlayerInput = Console.ReadLine();

            if (int.TryParse(PlayerInput, out PlayerNum))
            {
                PlayerNum = int.Parse(PlayerInput);

                if (PlayerNum > NumToGuess)
                {
                    Console.WriteLine("\nLower");
                    PressAny();
                    GuessNumber();
                }
                else if(PlayerNum < NumToGuess)
                {
                    Console.WriteLine("\nHigher");
                    PressAny();
                    GuessNumber();
                }
                else if(PlayerNum == NumToGuess)
                {
                    Console.WriteLine("\nCORRECT!");
                    Console.WriteLine("\nYou Have Guessed The Number!");
                    PressAny();
                    PlayAgain();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your Answer Can Not Be Used");
                PressAny();
                GuessNumber();
            }
        }

        static void PlayAgain()
        {
            Console.WriteLine("Would You Like To Play Again?\nY/N: ");
            Console.SetCursorPosition(6,1);
            PlayerInput = Console.ReadLine();
            PlayerInput = PlayerInput.ToLower();

            if(PlayerInput == "y" || PlayerInput == "yes")
            {
                keepGuessing = false;
            }
            else if(PlayerInput == "n" || PlayerInput == "no")
            {
                keepGuessing = false;
                endGame = true;
            }
            else
            {
                Console.WriteLine("Your Answer Was Not Applicable!\nPlease Try Again!");
                PressAny();
                PlayAgain();
            }
        }


        static void Main(string[] args)
        {
         
            if(writeIntro)
            {
                PrintStart();
            }

            while(true)
            {

                RandomNumber();

                while(keepGuessing)
                {
                    GuessNumber();
                }

                if(endGame)
                {
                    Console.Clear();
                    Console.WriteLine("Thank You For Playing!");
                    PressAny();
                    Environment.Exit(0);
                }


            }
        }
    }
}
