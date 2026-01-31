using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab9.Context;

namespace lab9.States
{
    internal interface IOrderState
    {
        void ProcessOrder(Order context);
        string GetStatusname();
    }
}
