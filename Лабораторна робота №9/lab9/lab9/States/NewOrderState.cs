using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab9.Context;

namespace lab9.States
{
    internal class NewOrderState : IOrderState
    {
        public string GetStatusname()
        {
            return "Нове замовлення (NewOrder)";
        }

        public void ProcessOrder(Order context)
        {
            Console.WriteLine("Оплачуємо замовлення та формуємо інвойс...");
            context.SetState(new InvoicedState());
        }
    }
}
