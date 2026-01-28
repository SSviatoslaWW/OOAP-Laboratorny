using lab2.Factories;
using lab2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main()
        {
            // Налаштування для коректного відображення літери 'і'
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.UTF8;

            IFacadeFactory factory = SelectMaterial();
            List<IFacade> order = new List<IFacade>();
            bool isOrdering = true;

            while (isOrdering)
            {
                Console.Clear();
                Console.WriteLine($"=== ЗАМОВЛЕННЯ: {factory.MaterialName.ToUpper()} ===");
                Console.WriteLine("1. Додати Суцільний фасад");
                Console.WriteLine("2. Додати Вітрину");
                Console.WriteLine("3. Сформувати замовлення та вийти");
                Console.Write("\nВаш вибір: ");

                string choice = Console.ReadLine();
                if (choice == "3") { isOrdering = false; continue; }

                Console.Write("Введіть ширину (м): ");
                double w = double.Parse(Console.ReadLine());
                Console.Write("Введіть висоту (м): ");
                double h = double.Parse(Console.ReadLine());

                if (choice == "1") order.Add(factory.CreateSolid(w, h));
                else if (choice == "2") order.Add(factory.CreateDisplay(w, h));
            }

            Console.Clear();
            Console.WriteLine("======= ПІДСУМКОВИЙ ЧЕК =======");
            double totalSum = 0;
            foreach (var item in order)
            {
                item.PrintInfo();
                totalSum += item.GetPrice();
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"РАЗОМ ДО ОПЛАТИ: {totalSum:F2} грн");
            Console.WriteLine("===============================");
        }

        static IFacadeFactory SelectMaterial()
        {
            Console.WriteLine("Оберіть матеріал для замовлення (всі фасади в чеку будуть цього типу):");
            Console.WriteLine("1. Плівкові\n2. Фарбовані\n3. Пластикові");
            string m = Console.ReadLine();

            switch (m)
            {
                case "1":
                    return new FilmFactory();
                case "2":
                    return new PaintedFactory();
                default:
                    return new PlasticFactory();
            }
        }
    }
}
