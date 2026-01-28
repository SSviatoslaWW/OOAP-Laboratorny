using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Implementations
{
    internal class BurtonProvider :ISnowboardProvider
    {
        public string GetIdentifier() 
        {
            return "Burton";
        } 
        public double GetUnitPrice()
        {
            return 550.0;
        }
        public double GetSetupPrice()
        {
            return 120.0;
        }
    }
}
