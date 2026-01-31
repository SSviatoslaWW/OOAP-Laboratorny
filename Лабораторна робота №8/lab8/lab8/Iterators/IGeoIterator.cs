using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.Iterators
{
    internal interface IGeoIterator
    {
        bool HasNext { get; }
        bool HasPrevious { get; }
        string Next();
        string Previous();

        void Reset();
    }
}
