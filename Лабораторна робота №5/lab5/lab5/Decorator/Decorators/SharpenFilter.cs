using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Decorator
{
    internal class SharpenFilter : ImageFilter
    {
        public SharpenFilter(IImage img) : base(img) { }
        public override double GetSizeOnDisk()
        {
            return base.GetSizeOnDisk() * 1.05;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " + Чіткість";
        }
    }
}
