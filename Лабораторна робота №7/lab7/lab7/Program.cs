using lab7.Component;
using lab7.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            IHandleEvent win = new Window("Головне Вікно");
            IHandleEvent frame = new Frame("Рамка Тексту");
            IHandleEvent panel = new Panel("Панель Інструментів");
            IHandleEvent btn = new Button("Кнопка 'Зберегти'");

            GuiEvent eventClick = new GuiEvent("Click");
            GuiEvent eventClose = new GuiEvent("Close");
            GuiEvent eventResize = new GuiEvent("Resize");
            GuiEvent eventScroll = new GuiEvent("Scroll");
            GuiEvent eventUnknow = new GuiEvent("Unknow");

            btn.SetNext(panel).SetNext(frame).SetNext(win);


            Console.WriteLine("--- Тест 1: Клік по кнопці (обробить сама кнопка) ---");
            btn.Handle(eventClick);
            Console.WriteLine("");

            Console.WriteLine("--- Тест 2: Зміна розміру (обробить рамка тексту) ---");
            btn.Handle(eventResize);
            Console.WriteLine("");

            Console.WriteLine("--- Тест 3: Скрол (обробить панель інструментів) ---");
            btn.Handle(eventScroll);
            Console.WriteLine("");

            Console.WriteLine("--- Тест 4: Закриття (обробить головне вікно) ---");
            btn.Handle(eventClose);
            Console.WriteLine("");

            Console.WriteLine("--- Тест 5: Невідрма подія (необробиться ніким) ---");
            btn.Handle(eventUnknow);
            Console.WriteLine("");
        }
    }
}
