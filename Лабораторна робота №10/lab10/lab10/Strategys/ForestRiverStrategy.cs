using lab10.Scenario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab10.Strategys
{
    internal class ForestRiverStrategy : IMovementStrategy
    {
        public string GetName() => "Тактика 'Водяний лис'";
        public string GetItems() => "Чоботи (Ліс) + Човен (Річка)";

        public bool CanPass(Scenariy scenario)
        {
            if (scenario.HasMountains) return false;
            return true;
        }
    }
}
