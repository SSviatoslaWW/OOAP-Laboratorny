using lab10.Scenario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab10.Strategys
{
    internal class StealthForestStrategy : IMovementStrategy 
    {
        public string GetName() => "Тактика 'Тінь'";
        public string GetItems() => "Плащ-невидимка (тільки Ліс)";

        public bool CanPass(Scenariy scenario)
        {
            return scenario.HasForest && !scenario.HasRiver && !scenario.HasMountains;
        }
    }
}
