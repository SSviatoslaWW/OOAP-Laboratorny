using lab7.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Component
{
    internal class Panel : GuiComponent
    {
        public Panel(string title) : base(title) { }
        public override void Handle(GuiEvent eventH)
        {
            if (eventH.Type == "Scroll")
            {
                Console.WriteLine("=========================================================================");
                Console.WriteLine($"Подію Scroll обробив {Title}");
                Console.WriteLine("=========================================================================");
            }
            else if (nextComponent != null)
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
