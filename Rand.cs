using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Rand : Player
    {
        private string name;
        private string input;
            
        public Rand(string name, Roshambo r1) : base(name, r1)
        {
            this.name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            random = new Random();
            return (Roshambo)random.Next(0, 3);
        }

        public override Roshambo GenerateRoshambo(string input)
        {
            return Roshambo.Paper;
        }

    }
}
