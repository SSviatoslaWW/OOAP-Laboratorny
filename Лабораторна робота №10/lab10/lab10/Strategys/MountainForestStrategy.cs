using lab10.Scenario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Strategys
{
    internal class MountainForestStrategy : IMovementStrategy
    {
        public string GetName() => "Тактика 'Гірський єгер'";
        public string GetItems() => "Мотузка (Гори) + Чоботи (Ліс)";

        public bool CanPass(Scenariy scenario)
        {
            if (scenario.HasRiver) return false;
            return true;
        }
    }
}
