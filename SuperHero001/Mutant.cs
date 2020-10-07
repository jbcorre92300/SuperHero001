using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero001
{
    public abstract class Mutant : Human
    {
        public Mutant (string name, string universe, string realname)
            : base(name, universe, realname )
        {
            Name = name;
            Universe = universe;
            Realname = realname;
        }

        public string Name { get; }
        public string Universe { get; }
        public string Realname { get; }
    }
}
