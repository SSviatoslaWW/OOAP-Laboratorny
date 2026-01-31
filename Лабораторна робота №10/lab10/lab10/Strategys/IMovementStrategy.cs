using lab10.Scenario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Strategys
{
    internal interface IMovementStrategy
    {
        string GetName();
        string GetItems();
        bool CanPass(Scenariy scenario); 
    }
}
