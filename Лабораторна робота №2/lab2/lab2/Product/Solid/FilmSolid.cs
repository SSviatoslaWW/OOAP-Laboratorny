using lab2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Product.Solid
{
    internal class FilmSolid :ISolidFacade
    {
        public string Title => "Суцільний фасад";
        public string Material { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetPrice() => Width * Height * 250;

        public void PrintInfo()
        {
            Console.WriteLine($"[{Title}] {Material} | Розмір: {Width}x{Height} м. | Ціна: {GetPrice():F2} грн");
        }
    }
}
