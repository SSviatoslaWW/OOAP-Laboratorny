using lab7.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Component
{
    internal class Button : GuiComponent
    {
        public Button(string title) : base(title) { }
        public override void Handle(GuiEvent eventH)
        {
            if (eventH.Type == "Click")
            {
                Console.WriteLine("=========================================================================");
                Console.WriteLine($"Подію Click обробив {Title}");
                Console.WriteLine("=========================================================================");
            }
            else if(nextComponent != null) 
            {
                Console.WriteLine($"{Title} неможе обробити подію передаю її далі до {nextComponent.Title}");
                base.Handle(eventH);
            }
            else
            {
                Console.WriteLine($"{Title} неможе обробити подію та передати тому що  кінець ланцюжка");
            }
        }
    }
}
