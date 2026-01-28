using lab3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Servises
{
    internal class HouseRegistry
    {
        private readonly Dictionary<string, House> prototypes = new Dictionary<string, House>();

        public void AddPrototype(string key, House prototype) 
        {
            prototypes[key] = prototype;
        } 

        public House GetClone(string key)
        {
            if (prototypes.TryGetValue(key, out var prototype))
                return prototype.Clone();

            throw new Exception("Прототип не знайдено!");
        }

        public List<string> GetKeys() 
        {
            return prototypes.Keys.ToList();
        } 
    }
}
