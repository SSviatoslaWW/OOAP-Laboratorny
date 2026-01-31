using lab3.Core;
using lab3.Models;
using lab3.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static HouseRegistry registry = new HouseRegistry();
        static List<House> myCollection = new List<House>();

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SeedPrototypes();

            while (true)
            {
                Console.WriteLine("\n=== МЕНЮ УПРАВЛІННЯ БУДИНКАМИ ===");
                Console.WriteLine("1. Переглянути шаблони (Прототипи)");
                Console.WriteLine("2. Створити будинок з шаблону та додати в контейнер");
                Console.WriteLine("3. Показати мій список будинків");
                Console.WriteLine("4. Корегувати існуючий будинок (клонувати)");
                Console.WriteLine("0. Вихід");
                Console.Write("Вибір: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": ShowTemplates(); break;
                    case "2": CreateFromTemplate(); break;
                    case "3": ShowCollection(); break;
                    case "4": EditByCloning(); break;
                    case "0": return;
                }
            }
        }

        static void SeedPrototypes()
        {
            registry.AddPrototype("котедж", new Cottage(120, 2, "Вул. Лісова", new Owner("Каранін")));
            registry.AddPrototype("жк", new ApartmentBuilding(2500, 9, "Вул. Центральна", new List<Owner> { new Owner("Петренко") }));
        }

        static void ShowTemplates()
        {
            Console.WriteLine("\n--- Доступні прототипи ---");
            foreach (var key in registry.GetKeys()) Console.WriteLine($"- {key}");
        }

        static void CreateFromTemplate()
        {
            ShowTemplates();
            Console.Write("Введіть назву шаблону: ");
            string key = Console.ReadLine();

            try
            {
                House newHouse = registry.GetClone(key);
                Console.Write("Введіть точну адресу: ");
                newHouse.Address = Console.ReadLine();

                myCollection.Add(newHouse);
                Console.WriteLine("Будинок додано!");
            }
            catch { Console.WriteLine("Помилка: назва невірна."); }
        }

        static void ShowCollection()
        {
            Console.WriteLine("\n--- Ваш контейнер будинків ---");
            for (int i = 0; i < myCollection.Count; i++)
                myCollection[i].ShowInfo($"ID: {i} |");
        }

        static void EditByCloning()
        {
            ShowCollection();
            Console.Write("ID будинку для корегування (створимо його копію): ");
            if (int.TryParse(Console.ReadLine(), out int id) && id >= 0 && id < myCollection.Count)
            {
                House clone = myCollection[id].Clone();
                Console.Write("Нова площа: ");
                clone.Area = double.Parse(Console.ReadLine());

                myCollection.Add(clone);
                Console.WriteLine("Копію з новими даними додано до списку!");
            }
        }
    }
}
