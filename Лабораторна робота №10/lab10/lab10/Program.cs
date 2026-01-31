using lab10.Context;
using lab10.Scenario;
using lab10.Strategys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var levels = new List<Scenariy> {
                new Scenariy("Тихий гай", true, false, false),
                new Scenariy("Крижана річка", false, true, true),
                new Scenariy("Зарослий каньйон", true, false, true),
                new Scenariy("Велике випробування", true, true, true)
            };

            Unit hero = new Unit("Артур", new ForestRiverStrategy());

            foreach (var level in levels)
            {
                Console.WriteLine("===========================================");
                hero.PlayScenario(level);

                if (level.Title == "Тихий гай")
                {
                    hero.SetStrategy(new MountainForestStrategy());
                }
            }

            Console.ReadKey();
        }
    }
}
