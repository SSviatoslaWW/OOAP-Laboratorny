using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Decorator.Decorators
{
    internal class NoiseFilter : ImageFilter
    {
        public NoiseFilter(IImage img) : base(img) { }
        public override double GetSizeOnDisk()
        {
            return base.GetSizeOnDisk() * 1.2;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " + Шум";
        }
    }
}
