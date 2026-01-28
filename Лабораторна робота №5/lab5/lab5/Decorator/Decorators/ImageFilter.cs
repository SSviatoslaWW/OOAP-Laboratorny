using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Decorator
{
    internal abstract class ImageFilter :IImage
    {
        protected IImage image;
        protected ImageFilter(IImage image)
        {
            this.image = image;
        }
        public virtual double GetPixels()
        {
            return image.GetPixels();
        }
        public virtual double GetSizeOnDisk()
        {
            return image.GetSizeOnDisk();
        }
        public virtual string GetDescription()
        {
            return image.GetDescription();
        }
    }
}
