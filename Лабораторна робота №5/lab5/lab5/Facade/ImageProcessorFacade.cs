using lab5.Decorator;
using lab5.Decorator.Decorators;
using lab5.Decorator.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Facade
{
    internal class ImageProcessorFacade
    {
        private List<IImage> gallery = new List<IImage>();

        public void AddImage(string type, double px, double size)
        {
            IImage img;
            if (type == "1")
            {
                img = new ColorImage(px, size);
            }
            else
            {
                img = new BWImage(px, size);
            }
            gallery.Add(img);
            Console.WriteLine("Фото додано успішно.");
        }

        public void ApplyFilter(int index, string choice)
        {
            if (index < 0 || index >= gallery.Count)
            {
                Console.WriteLine("Помилка: Невірний індекс!");
                return;
            }

            IImage current = gallery[index];

            switch (choice)
            {
                case "1":
                    gallery[index] = new BlurFilter(current);
                    break;

                case "2":
                    gallery[index] = new SharpenFilter(current);
                    break;

                case "3":
                    gallery[index] = new SaturationFilter(current);
                    break;

                case "4":
                    gallery[index] = new NoiseFilter(current);
                    break;

                case "5":
                    gallery[index] = new CircleCropFilter(current);
                    break;

                case "6":
                    gallery[index] = new RectCropFilter(current);
                    break;

                default:
                    gallery[index] = current;
                    break;
            }

            Console.WriteLine("Фільтр застосовано.");
        }

        public void ShowGallery(bool sortBySize = false)
        {
            var list = sortBySize ? gallery.OrderBy(i => i.GetSizeOnDisk()).ToList() : gallery;

            Console.WriteLine("\n======= ВАША ГАЛЕРЕЯ =======");
            if (!list.Any()) Console.WriteLine("Галерея порожня.");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"[{i}] {list[i].GetDescription()}");
                Console.WriteLine($"    Пікселів: {list[i].GetPixels():F0} | Розмір: {list[i].GetSizeOnDisk():F2} MB");
            }
            Console.WriteLine("============================\n");
        }

        public int Count
        {
            get
            {
                return gallery.Count;
            }
        }
    }
}
