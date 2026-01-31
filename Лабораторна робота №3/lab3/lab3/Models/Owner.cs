using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Models
{
    internal class Owner
    {
        public string FullName { get; set; }
        public Owner(string name) 
        {
            FullName = name;
        } 

        public Owner Clone()
        {
            return new Owner(FullName);
        }
    }
}
