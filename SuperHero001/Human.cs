using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero001
{
    public abstract class Human : SuperHero
    {
        public Human(string name, string universe, string realname)
            : base(name, universe)
        {
            Name = name;
            Universe = universe;
            Realname = realname;

        }

        public override string ToString()
        {
            return $"\n{Name} from {Universe} Universe. His real name is {Realname} \n";


        }

        public string Name { get; }
        public string Universe { get; }
        public string Realname { get; }


    }
}
