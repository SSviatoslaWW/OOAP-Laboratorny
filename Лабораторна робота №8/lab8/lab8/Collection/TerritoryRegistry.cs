using lab8.GeoTree;
using lab8.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.Collection
{
    internal class TerritoryRegistry : IGeoCollection
    {
        private GeoNode root;
        public TerritoryRegistry(GeoNode root) => this.root = root;

        public IGeoIterator CreateDepthIterator() => new DepthIterator(root);
        public IGeoIterator CreateBreadthIterator() => new BreadthIterator(root);
    }
}
