using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Interface
{
    internal interface IFacade
    {
        string Title { get; }      
        string Material { get; set; } 
        double Width { get; set; }
        double Height { get; set; }

        double GetPrice();
        void PrintInfo();
    }
}
