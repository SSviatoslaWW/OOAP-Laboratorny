using lab8.GeoTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.Iterators
{
    internal class BreadthIterator : IGeoIterator
    {
        private List<GeoNode> history = new List<GeoNode>();
        private int currentIndex = -1;

        public BreadthIterator(GeoNode root)
        {
            if (root == null) return;
            Queue<GeoNode> queue = new Queue<GeoNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                history.Add(current);
                foreach (GeoNode child in current.Children)
                    queue.Enqueue(child);
            }
        }

        public bool HasNext => currentIndex + 1 < history.Count;
        public bool HasPrevious => currentIndex > 0;
        public string Next() => HasNext ? history[++currentIndex].Name : null;
        public string Previous()
        {
            if (HasPrevious)
            {
                string name = history[currentIndex].Name;

                currentIndex--;

                return name;
            }
            return null;
        }
        public void Reset() => currentIndex = -1;
    }
}
