using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero001
{
    public abstract class SuperHero
    {
        public SuperHero(string name, string universe)
        {
            Name = name;
            Universe = universe;
        }

        public string Name { get; }
        public string Universe { get; }

        public override string ToString()
        {
            return $"\n{Name} from {Universe} Universe.\n ";


        }
    }



    interface IFlyable
    {
        void Fly();
    }

    interface ISeeThrough
    {
        void LookThrough();
    }

    interface IStrength
    {
        void Strength();
    }

    interface ITechnology
    {
        void Technology();
    }

    interface IRegenerative
    {
        void Regenerative();
    }
}
