using lab4.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Abstraction
{
    internal interface SnowboardRental
    {
        void AddQuantity(int count);
        double GetTotalOrderPrice();

        void ShowDetails();
    }
}
