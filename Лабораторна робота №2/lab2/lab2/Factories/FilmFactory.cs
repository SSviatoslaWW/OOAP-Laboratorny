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
    internal class FilmFactory : IFacadeFactory
    {
        public string MaterialName => "Плівка";

        public IFacade CreateSolid(double w, double h)
        {
            return new FilmSolid
            {
                Width = w,
                Height = h,
                Material = this.MaterialName
            };
        }


        public IFacade CreateDisplay(double w, double h)
        {
            return new FilmDisplay
            {
                Width = w,
                Height = h,
                Material = this.MaterialName
            };
        }
    }
}
