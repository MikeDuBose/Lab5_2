using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class Rock : Player
    {
        private string name;
        private string input;
        private Roshambo r1;

        public Rock(string name, Roshambo r1) : base(name, r1)
        {
            this.name = name;
            this.r1 = r1;
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
        public override Roshambo GenerateRoshambo(string input)
        {
            return Roshambo.Paper;
        }

    }
}
