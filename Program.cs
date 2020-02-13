using System;
using System.Collections.Generic;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Roshambo r1 = new Roshambo();
            Play();
        }

        public static void Play()
        {
            Roshambo r1 = new Roshambo();
            Player human = new Human("Your name", r1, "");
            Player rocky = new Rock("Rocky Balboa", r1);
            Player rand = new Rand("Random mand", r1);
            Console.WriteLine("Please select a player(1 or 2): ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Player rock = new Rock("Rocky Balboa", r1);
            }
            else if (input == "2")
            {
                rand = new Rand("Random man", r1);
            }
            else
            {
                Console.WriteLine("That was invalid.");
                Play();
            }
            Console.WriteLine("Please enter rock, paper, or scissors: ");
            string input2 = Console.ReadLine();
            if (input2.ToLower() != "rock" && input2.ToLower() != "paper" && input2.ToLower() != "scissors")
            {
                Console.WriteLine("Invalid");
                Play();
            }
            else
            {
                human = new Human("Your name", r1, input2);
                if (input == "1")
                {
                    Console.WriteLine(Compete(human.GenerateRoshambo(input2), rocky.GenerateRoshambo()));
                }
                else if (input == "2")
                {
                    Console.WriteLine(Compete(human.GenerateRoshambo(input2), rand.GenerateRoshambo()));
                }
            }
            Proceed();
        }
        public static void Proceed()
        {
            Console.WriteLine("Would you like to try again? Y/N :");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                Play();
            }
            else if (input == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid entry.  Try again. ");
                Proceed();
            }
        }
        public static string Compete(Roshambo one, Roshambo two)
        {
            if (one == Roshambo.Paper && two == Roshambo.Rock)
            {
                Console.WriteLine("The computer plays rock!\n");
                return "You win!";
            }
            else if (one == Roshambo.Paper && two == Roshambo.Paper)
            {
                Console.WriteLine("The computer plays paper!\n");
                return "It's a tie!";
            }
            else if (one == Roshambo.Paper && two == Roshambo.Scissors)
            {
                Console.WriteLine("The computer plays scissors!\n");
                return "Computer wins!";
            }
            else if (one == Roshambo.Rock && two == Roshambo.Paper)
            {
                Console.WriteLine("The computer plays paper!\n");
                return "Computer wins!";
            }
            else if (one == Roshambo.Rock && two == Roshambo.Rock)
            {
                Console.WriteLine("The computer plays rock!\n");

                return "It's a tie!";
            }
            else if (one == Roshambo.Rock && two == Roshambo.Scissors)
            {
                Console.WriteLine("The computer plays scissors!\n");
                return "You win!";
            }
            else if (one == Roshambo.Scissors && two == Roshambo.Rock)
            {
                Console.WriteLine("The computer plays rock!\n");

                return "Computer wins!";
            }
            else if (one == Roshambo.Scissors && two == Roshambo.Paper)
            {
                Console.WriteLine("The computer plays paper!\n");

                return "You win!";
            }
            else if (one == Roshambo.Scissors && two == Roshambo.Scissors)
            {
                Console.WriteLine("The computer plays scissors!\n");

                return "It's a tie!";
            }
            else return "Ahh!";

        }
    }
}
