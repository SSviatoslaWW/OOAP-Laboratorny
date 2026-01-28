using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna1.AbstractSuperClass
{
    internal class Square : Shape
    {
        double lenght;
        public double Lenght { get; set; }
        public Square(double lenght) : base()
        {
            NameShape = "Квадрат";
            Lenght = lenght;
        }

        public override double AreaCalculate()
        {
            return Lenght * Lenght;
        }
    }
}
