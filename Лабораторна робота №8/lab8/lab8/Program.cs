using lab8.Collection;
using lab8.GeoTree;
using lab8.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            GeoNode ua = new GeoNode("Україна");
            GeoNode lviv = ua.AddChild("Львівська обл.");
            GeoNode kyiv = ua.AddChild("Київська обл.");

            GeoNode lvivDist = lviv.AddChild("Львівський р-н");
            GeoNode lvivCity = lvivDist.AddChild("Львів");
            lvivCity.AddChild("вул. Городоцька");
            lvivCity.AddChild("вул. Коперника");

            GeoNode btsDist = kyiv.AddChild("Білоцерківський р-н");
            GeoNode btsCity = btsDist.AddChild("Біла Церква");
            btsCity.AddChild("вул. Театральна");
            btsCity.AddChild("вул. Вокзальна");

            IGeoCollection registry = new TerritoryRegistry(ua);

            // 1. Тест Глибини
            Console.WriteLine("=== ОБХІД В ГЛИБИНУ (DFS) ===");
            Console.WriteLine("=== ВПЕРЕД ===");
            IGeoIterator dfs = registry.CreateDepthIterator();
            while (dfs.HasNext) Console.WriteLine("-> " + dfs.Next());
            Console.WriteLine("=== НАЗАД ===");
            while (dfs.HasPrevious) Console.WriteLine("-> " + dfs.Previous());

            // 2. Тест Ширини
            Console.WriteLine("\n=== ОБХІД В ШИРИНУ (BFS) ===");
            IGeoIterator bfs = registry.CreateBreadthIterator();
            Console.WriteLine("=== ВПЕРЕД ===");
            while (bfs.HasNext) Console.WriteLine("-> " + bfs.Next());
            Console.WriteLine("=== НАЗАД ===");
            while (bfs.HasPrevious) Console.WriteLine("-> " + bfs.Previous());
        }
    }
}
