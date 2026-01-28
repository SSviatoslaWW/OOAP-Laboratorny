using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Actor
    {
        private string name;

        public Actor(string name)
        {
            this.name = name;
        }

        public void Perform(string costume, string scene)
        {
            Console.WriteLine($"Актор {name} у костюмі '{costume}' виступає в сцені: {scene}");
        }
    }
}
