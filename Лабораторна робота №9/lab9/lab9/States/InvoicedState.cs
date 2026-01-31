using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab9.Context;

namespace lab9.States
{
    internal class InvoicedState : IOrderState
    {
        public string GetStatusname()
        {
            return "Оплачено (Invoiced)";
        }

        public void ProcessOrder(Order context)
        {
            Console.WriteLine("Пакуємо товар та передаємо кур'єру...");
            context.SetState(new ShippedState());
        }
    }
}
