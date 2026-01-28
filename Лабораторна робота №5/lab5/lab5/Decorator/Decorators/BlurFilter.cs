using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Decorator
{
    internal class BlurFilter : ImageFilter
    {
        public BlurFilter(IImage img) : base(img) { }
        public override double GetSizeOnDisk()
        {
            return base.GetSizeOnDisk() * 1.1;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " + Розмиття";
        }
    }
}
