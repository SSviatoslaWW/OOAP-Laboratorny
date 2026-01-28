using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna1.AbstractSuperClass
{
    internal  abstract class Shape
    {
        string nameShape;

        public Shape()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("                   Об'єкт створено");
            Console.WriteLine("========================================================");
        }
        public void PrintInformation()
        {
            Console.WriteLine("Назва фігури: " + NameShape);
            Console.WriteLine("Площа: " + AreaCalculate());
        }

        public string NameShape
        {
            get
            {
                return nameShape;
            }

            set
            {
                nameShape = value;
            }
        }

        public abstract double AreaCalculate();
    }
}
