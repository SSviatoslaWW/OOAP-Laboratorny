using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Core
{
    internal abstract class House
    {
        public double Area { get; set; }
        public int Floors { get; set; }
        public string Address { get; set; }

        public abstract House Clone();
        public abstract void ShowInfo(string prefix = "");
    }
}
