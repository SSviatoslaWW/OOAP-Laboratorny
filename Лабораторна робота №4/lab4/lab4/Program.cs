using lab4.Abstraction;
using lab4.Implementations;
using System;
using System.Collections.Generic;

namespace lab4
{
    internal class Program
    {
        // Наш кошик (контейнер для різних "містків")
        static List<SnowboardRental> cart = new List<SnowboardRental>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n===== СИСТЕМА ПРОКАТУ (BRIDGE + CART) =====");
                Console.WriteLine("1. Додати товар до кошика");
                Console.WriteLine("2. Переглянути кошик та підсумок");
                Console.WriteLine("3. Очистити кошик");
                Console.WriteLine("0. Вихід");
                Console.Write("Вибір: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItemToCart();
                        break;
                    case "2":
                        ShowCart();
                        break;
                    case "3":
                        cart.Clear();
                        Console.WriteLine("Кошик порожній.");
                        break;
                    case "0":
                        return;
                }
            }
        }

        static void AddItemToCart()
        {
            ISnowboardProvider provider = null;

            while (provider == null)
            {
                Console.WriteLine("\nОберіть фірму:");
                Console.WriteLine("1. Burton");
                Console.WriteLine("2. Rossignol");
                string fChoice = Console.ReadLine();

                if (fChoice == "1") provider = new BurtonProvider();
                else if (fChoice == "2") provider = new RossignolProvider();
                else Console.WriteLine("Невірний вибір!");
            }

            Console.Write("Розмір черевик: ");
            int size = int.Parse(Console.ReadLine() ?? "40");

            Console.Write("Кріплення (Left/Right): ");
            string dir = Console.ReadLine() ?? "Right";

            Console.Write("Кількість одиниць: ");
            int count = int.Parse(Console.ReadLine() ?? "1");

            SnowboardRental newItem = new SkiMuneris(provider, size, dir);
            newItem.AddQuantity(count);

            // Додаємо в кошик
            cart.Add(newItem);
            Console.WriteLine("Товар додано!");
        }

        static void ShowCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("\nКошик порожній!");
                return;
            }

            Console.WriteLine("\n--- ВАШЕ ЗАМОВЛЕННЯ ---");
            double totalSum = 0;

            for (int i = 0; i < cart.Count; i++)
            {
                Console.Write($"#{i + 1} ");
                cart[i].ShowDetails();
                totalSum += cart[i].GetTotalOrderPrice();
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"ЗАГАЛЬНА СУМА ДО СПЛАТИ: {totalSum} грн");
        }
    }
}