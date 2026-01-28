using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna1.AbstractSuperClass
{
    internal class Circle : Shape
    {
        double radius;

        public double Radius { get; set; }  

        public Circle(double radius)
        {
            this.Radius = radius;
            NameShape = "Круг";
        }

        public override double AreaCalculate()
        {
            return Radius * Math.Pow(Math.PI, 2);
        }
    }
}
