using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    abstract class Player
    {
        protected string name;
        protected int speed;
        protected Roshambo r;


        //Protected because this exists for Players, nothing else
        protected static Random random;

        public Player(string name, Roshambo r)
        {
            this.Name = name;
            this.r = r;
        }
        public string Name { get => name; set => name = value; }
        public abstract Roshambo GenerateRoshambo();
        public abstract Roshambo GenerateRoshambo(string input);

    }
}
