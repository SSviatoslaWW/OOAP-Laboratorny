using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Implementations
{
    internal class RossignolProvider : ISnowboardProvider
    {
        public string GetIdentifier()
        {
            return "Rossignol";
        }
        public double GetUnitPrice()
        {
            return 420.0;
        }
        public double GetSetupPrice()
        {
            return 90.0;
        }
    }
}
