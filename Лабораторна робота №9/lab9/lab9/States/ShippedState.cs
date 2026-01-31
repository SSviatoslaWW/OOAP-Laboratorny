using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab9.Context;

namespace lab9.States
{
    internal class ShippedState : IOrderState
    {
        public string GetStatusname()
        {
            return "Відправлено (Shipped)";
        }

        public void ProcessOrder(Order context)
        {
            Console.WriteLine("Замовлення вже відправлено. Очікуйте на доставку!");
        }
    }
}
