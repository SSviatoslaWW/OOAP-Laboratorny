using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Decorator.Image
{
    internal class BWImage : IImage
    {
        double Pixels { get; set; }
        double Size { get; set; }
        public BWImage(double pixels, double size)
        {
            Pixels = pixels;
            Size = size;
        }
        public double GetPixels()
        {
            return Pixels;
        }
        public double GetSizeOnDisk()
        {
            return Size;
        }
        public string GetDescription()
        {
            return "Чорно-біле фото";
        }
    }
}
