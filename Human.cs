using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Human : Player
    {
        private string name;
        private string input;
        private Roshambo r1;

        public Human(string name, Roshambo r1, string input) : base(name, r1)
        {
            this.name = name;
            this.input = input;
            this.r1 = r1;
        }

        public override Roshambo GenerateRoshambo(string input)
        {
            while (input.ToLower() != "rock" && input.ToLower() != "scissors" && input.ToLower() != "rock")
            {
                Console.WriteLine("Incorrect input, please try again.");
            }

            if(input.ToLower() == "rock")
            {
                return Roshambo.Rock;
            }
            else if (input.ToLower() == "scissors")
            {
                return Roshambo.Scissors;
            }
            else
            return Roshambo.Paper;
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Paper;
        }
    }
}
