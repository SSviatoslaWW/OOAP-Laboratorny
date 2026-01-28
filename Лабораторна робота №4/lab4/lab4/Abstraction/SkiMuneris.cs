using lab4.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Abstraction
{
    internal class SkiMuneris
    {
        ISnowboardProvider provider;

        public int ShoeSize { get; set; }
        public string Direction { get; set; }
        public int Quantity { get; private set; }

        public SkiMuneris(ISnowboardProvider provider, int shoeSize, string direction)
        {
            this.provider = provider;
            ShoeSize = shoeSize;
            Direction = direction;
            Quantity = 0;
        }

        public void AddQuantity(int amount)
        {
            Quantity += amount;
        }

        public double GetTotalOrderPrice()
        {
            return (provider.GetUnitPrice() * Quantity) + provider.GetSetupPrice();
        }

        public void ShowDetails()
        {
            Console.WriteLine("\n--- ДЕТАЛІ ЗАМОВЛЕННЯ ---");
            Console.WriteLine($"Об'єкт проката: {provider.GetIdentifier()}");
            Console.WriteLine($"Розмір черевик: {ShoeSize} | Кріплення: {Direction}");
            Console.WriteLine($"Кількість: {Quantity} шт.");
            Console.WriteLine($"Ціна одиниці: {provider.GetUnitPrice()} грн");
            Console.WriteLine($"Вартість налаштування: {provider.GetSetupPrice()} грн");
            Console.WriteLine($"ЗАГАЛЬНА СУМА: {GetTotalOrderPrice()} грн");
        }
    }
}
