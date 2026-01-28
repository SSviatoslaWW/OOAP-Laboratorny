using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Decorator.Decorators
{
    internal class CircleCropFilter : ImageFilter
    {
        public CircleCropFilter(IImage img) : base(img) { }
        public override double GetPixels()
        {
            return base.GetPixels() * 0.78;
        }
        public override double GetSizeOnDisk()
        {
            return base.GetSizeOnDisk() * 0.8;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " [Коло]";
        }
    }
}
