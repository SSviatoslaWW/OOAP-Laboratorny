using lab2.Interface;
using lab2.Product.Display;
using lab2.Product.Solid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Factories
{
    internal class PlasticFactory : IFacadeFactory
    {
        public string MaterialName => "Пластик";

        public ISolidFacade CreateSolid(double w, double h) 
        {
            return new PlasticSolid { Width = w, 
                                      Height = h, 
                                      Material = this.MaterialName 
            };
        }
            

        public IDisplayFacade CreateDisplay(double w, double h)
        {
            return new PlasticDisplay { Width = w, 
                                        Height = h, 
                                        Material = this.MaterialName 
            };
        }
            
    }
}
