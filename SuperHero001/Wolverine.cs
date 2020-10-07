using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero001
{
    public class Wolverine : Mutant, IStrength, IRegenerative
    {
        public Wolverine(string name, string universe, string realname)
            : base(name, universe, realname)
        {
            Name = name;
            Universe = universe;
            Realname = realname;
        }

        public string Name { get; }
        public string Universe { get; }
        public string Realname { get; }
        
        public void Regenerative()
        {
            Console.WriteLine("I have regenerative power");
        }

        public void Strength()
        {
            Console.WriteLine("I am super strong");
        }

        

       /* public override string ToString()
        {
            return $"{Name} from {Universe} Universe. His real name is {Realname} ";


        }*/

        public void Powers()
        {
            Strength();
            Regenerative();
        }

    }
}
