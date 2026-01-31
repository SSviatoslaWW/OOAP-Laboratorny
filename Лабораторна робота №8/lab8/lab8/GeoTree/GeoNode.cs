using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.GeoTree
{
    internal class GeoNode
    {
        public string Name { get; set; }
        public List<GeoNode> Children { get; set; } = new List<GeoNode>();

        public GeoNode(string name) => Name = name;

        public GeoNode AddChild(string name)
        {
            GeoNode node = new GeoNode(name);
            Children.Add(node);
            return node;
        }
    }
}
