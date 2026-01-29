using lab2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Product.Display
{
    internal class PaintedDisplay : IDisplayFacade
    {
        public string Title => "Вітринний фасад";
        public string Material { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetPrice()
        {
            return (Width * Height * 350) + 150;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[{Title}] {Material} | Розмір: {Width}x{Height} м. | Ціна: {GetPrice():F2} грн");
        }
    }
}
