using lab10.Strategys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab10.Scenario;

namespace lab10.Context
{
    internal class Unit
    {
        private IMovementStrategy strategy; 
        public string Name { get; }

        public Unit(string name, IMovementStrategy strategy)
        {
            Name = name;
            this.strategy = strategy;
        }

        public void SetStrategy(IMovementStrategy newStrategy)
        {
            strategy = newStrategy;
            Console.WriteLine($"[Юніт {Name} змінив артефакти на: {strategy.GetItems()}]");
        }

        public void PlayScenario(Scenariy scenario)
        {
            Console.WriteLine($"\nЮніт {Name} входить у '{scenario.Title}'...");
            Console.WriteLine($"Використовується {strategy.GetName()} ({strategy.GetItems()})");

            if (strategy.CanPass(scenario))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("РЕЗУЛЬТАТ: Сценарій пройдено успішно!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("РЕЗУЛЬТАТ: Юніт застряг! Не вистачає потрібного артефакту.");
            }
            Console.ResetColor();
        }
    }
}
