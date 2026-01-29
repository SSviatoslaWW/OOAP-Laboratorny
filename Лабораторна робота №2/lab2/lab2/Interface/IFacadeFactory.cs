using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Interface
{
    internal interface IFacadeFactory
    {
        string MaterialName { get; }
        ISolidFacade CreateSolid(double w, double h);
        IDisplayFacade CreateDisplay(double w, double h);
    }
}
