using lab10.Scenario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Strategys
{
    internal class RiverMountainStrategy : IMovementStrategy
    {
        public string GetName() => "Тактика 'Штурмовик каньйонів'";
        public string GetItems() => "Човен (Річка) + Мотузка (Гори)";

        public bool CanPass(Scenariy scenario)
        {
            if (scenario.HasForest) return false;
            return true;
        }
    }
}
