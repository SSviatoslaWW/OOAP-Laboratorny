using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Implementations
{
    internal interface ISnowboardProvider
    {
        string GetIdentifier();
        double GetUnitPrice();
        double GetSetupPrice();
    }
}
