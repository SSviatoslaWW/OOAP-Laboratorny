using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Scenario
{
    internal class Scenariy
    {
        public string Title { get; }
        public bool HasForest { get; }
        public bool HasRiver { get; }
        public bool HasMountains { get; }

        public Scenariy(string title, bool f, bool r, bool m)
        {
            Title = title; HasForest = f; HasRiver = r; HasMountains = m;
        }
    }
}
