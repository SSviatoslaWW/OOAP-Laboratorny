using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class ActorFactory
    {
        private Dictionary<string, Actor> actors = new Dictionary<string, Actor>();

        public Actor GetActor(string name)
        {
            if (!actors.ContainsKey(name))
            {
                actors[name] = new Actor(name);
                Console.WriteLine($"[Театр]: Найнято нового актора — {name}.");
            }
            return actors[name];
        }

        public int TotalActorsCount()
        {
            return actors.Count;
        }
    }
}
