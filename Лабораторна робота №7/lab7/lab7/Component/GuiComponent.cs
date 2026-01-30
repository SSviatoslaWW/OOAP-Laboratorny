using lab7.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Component
{
    internal abstract class GuiComponent : IHandleEvent
    {
        protected IHandleEvent nextComponent;
        public string Title { get; set; }

        public GuiComponent(string name)
        {
            Title = name;
        }

        public IHandleEvent SetNext(IHandleEvent handleEvent)
        {
            nextComponent = handleEvent;
            return handleEvent;
        }

        public virtual void Handle(GuiEvent guiEvent)
        {
            nextComponent.Handle(guiEvent);
        }
    }
}
