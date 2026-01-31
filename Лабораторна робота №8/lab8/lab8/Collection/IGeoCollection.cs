using lab8.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.GeoTree
{
    internal interface IGeoCollection
    {
        IGeoIterator CreateDepthIterator();   
        IGeoIterator CreateBreadthIterator(); 
    }
}
