using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Decorator.Decorators
{
    internal class RectCropFilter : ImageFilter
    {
        public RectCropFilter(IImage img) : base(img) { }
        public override double GetPixels()
        {
            return base.GetPixels() * 0.5;
        }
        public override double GetSizeOnDisk()
        {
            return base.GetSizeOnDisk() * 0.55;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " [Прямокутник]";
        }
    }
}
