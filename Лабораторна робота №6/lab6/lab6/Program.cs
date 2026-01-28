using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ActorFactory theater = new ActorFactory();

            string scene1 = "Площа міста";
            string[] rolesScene1 = { "Селянин", "Торговець", "Перехожий", "Вартовий" };

            string[] actorPool = { "Іван", "Марія" };

            Console.WriteLine($"\n--- {scene1} ---");
            for (int i = 0; i < rolesScene1.Length; i++)
            {
                Actor actor = theater.GetActor(actorPool[i % actorPool.Length]);
                actor.Perform(rolesScene1[i], scene1);
            }

            string scene2 = "Королівський бал";
            string[] rolesScene2 = { "Принц", "Графиня", "Лакей", "Музикант" };

            Console.WriteLine($"\n--- {scene2} ---");
            for (int i = 0; i < rolesScene2.Length; i++)
            {
                Actor actor = theater.GetActor(actorPool[i % actorPool.Length]);
                actor.Perform(rolesScene2[i], scene2);
            }

            Console.WriteLine($"\nПідсумок: Ролей зіграно: 8. Акторів у штаті: {theater.TotalActorsCount()}.");
        }
    }
}
