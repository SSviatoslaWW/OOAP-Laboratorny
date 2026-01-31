using lab9.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Order aliOrder = new Order("ALI-12345");

            Console.WriteLine("\nКрок 1:");
            aliOrder.NextStep(); 

            Console.WriteLine("\nКрок 2:");
            aliOrder.NextStep();

            Console.WriteLine("\nКрок 3:");
            aliOrder.NextStep();
        }
    }
}
