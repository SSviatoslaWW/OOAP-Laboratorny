using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Event
{
    internal class GuiEvent
    {
        public string Type { get; set; } 

        public GuiEvent(string type)
        {
            Type = type;
        }
    }
}
