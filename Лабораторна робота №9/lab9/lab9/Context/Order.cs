using lab9.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9.Context
{
    internal class Order
    {
        IOrderState stateOrder;
        public string OrderNumber { get; }

        public Order(string number)
        {
            this.OrderNumber = number;
            stateOrder = new NewOrderState();
            Console.WriteLine($"Замовлення {OrderNumber} створено. Стан: {stateOrder.GetStatusname()}");
        }

        public void SetState(IOrderState state)
        {
            stateOrder = state;
            Console.WriteLine($"--- Статус змінено на: {stateOrder.GetStatusname()} ---");
        }

        public void NextStep()
        {
            stateOrder.ProcessOrder(this);
        }
    }
}
