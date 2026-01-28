using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna1.AbstractSuperClass
{
    internal class Rectangle : Shape
    {
        double lenght;
        double width;

        public double Lenght { get; set; }
        public double Width { get; set; }

        public Rectangle(double lenght, double width) : base()
        {
            NameShape = "Прямокутник";
            Width = width;
            Lenght = lenght;
        }

        public override double AreaCalculate()
        {
            return Lenght * Width;
        }
    }
}
