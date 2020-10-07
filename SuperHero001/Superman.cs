using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero001
{
    public class SuperMan : Alien, IFlyable, ISeeThrough, IStrength
    {
        public SuperMan (string name, string universe, string realname)
            : base(name, universe)
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

        public override string ToString()
        {
            return $"\n{Name} from {Universe} Universe. His real name is {Realname}\n ";


        }

        public void Powers()
        {
            Strength();
            LookThrough();
            Fly();
        }

    }
}
