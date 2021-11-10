﻿using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method / ponto de entrada
        static void Main()
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {
                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while(guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMenssage(ConsoleColor.Red, "Please use an actual number");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMenssage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }
                PrintColorMenssage(ConsoleColor.Yellow, "You are CORRECT!");

                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Numeber Guesser";
            string appVersion = "1.0.0";
            string appAutor = "Diego";

            //Change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAutor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play the game", inputName);
        }

        static void PrintColorMenssage(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}