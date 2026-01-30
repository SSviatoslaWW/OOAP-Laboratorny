using lab7.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Component
{
    internal interface IHandleEvent
    {
        IHandleEvent SetNext(IHandleEvent handler);
        string Title { get; set; }
        void Handle(GuiEvent request);
    }
}
