using laboratorna1.AbstractSuperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Shape rectangle = new Rectangle(4, 5);
            rectangle.PrintInformation();

            Shape square = new Square(4);
            square.PrintInformation();

            Shape circle = new Circle(5);
            circle.PrintInformation();

        }
    }
}
