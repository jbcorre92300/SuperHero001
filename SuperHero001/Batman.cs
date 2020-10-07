using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero001
{
    public class Batman : Human, IFlyable, IStrength, ITechnology
    {
        public Batman(string name, string universe, string realname)
            : base(name, universe,realname)
        {
            Name = name;
            Universe = universe;
            Realname = realname;
        }

        public string Name { get; }
        public string Universe { get; }
        public string Realname { get; }
        public void Fly()
        {
            Console.WriteLine("I defy gravity");
        }
        public void LookThrough()
        {
            Console.WriteLine("I have X-Ray vision");
        }

        public void Strength()
        {
            Console.WriteLine("I am super strong");
        }

        public void Technology()
        {
            Console.WriteLine("I use very high technology");
        }

        /*public override string ToString()
        {
            return $"{Name} from {Universe} Universe. His real name is {Realname} ";


        }*/

        public void Powers()
        {
            Strength();
            Technology();
            Fly();
        }

    }
}
