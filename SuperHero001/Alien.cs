using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero001
{
    public abstract class Alien : SuperHero
    {
        public Alien (string name, string universe)
            : base(name, universe)
        {
            Name = name;
            Universe = universe;
        }

        public string Name { get; }
        public string Universe { get; }
    }
}
