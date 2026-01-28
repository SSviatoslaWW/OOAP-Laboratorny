using lab5.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ImageProcessorFacade facade = new ImageProcessorFacade();
            bool running = true;

            while (running)
            {
                Console.WriteLine("--- ГОЛОВНЕ МЕНЮ ---");
                Console.WriteLine("1. Додати нове фото");
                Console.WriteLine("2. Застосувати фільтр до фото");
                Console.WriteLine("3. Показати всю галерею (сортування за розміром)");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Тип (1 - Кольорове, 2 - Ч/Б): ");
                        string type = Console.ReadLine();
                        Console.Write("Кількість пікселів: ");
                        double px = double.Parse(Console.ReadLine());
                        Console.Write("Початковий розмір (MB): ");
                        double size = double.Parse(Console.ReadLine());
                        facade.AddImage(type, px, size);
                        break;

                    case "2":
                        facade.ShowGallery();
                        if (facade.Count == 0) break;
                        Console.Write("Введіть номер фото: ");
                        int idx = int.Parse(Console.ReadLine());

                        Console.WriteLine("Оберіть фільтр:");
                        Console.WriteLine("1-Blur, 2-Sharpen, 3-Saturation, 4-Noise, 5-Circle, 6-Rect");
                        string fChoice = Console.ReadLine();
                        facade.ApplyFilter(idx, fChoice);
                        break;

                    case "3":
                        facade.ShowGallery(sortBySize: true);
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Невірний ввід!");
                        break;
                }
            }
        }
    }
}

