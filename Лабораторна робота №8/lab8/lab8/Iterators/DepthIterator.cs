using lab8.GeoTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8.Iterators
{
    internal class DepthIterator : IGeoIterator
    {
        private List<GeoNode> history = new List<GeoNode>();
        private int currentIndex = -1;

        public DepthIterator(GeoNode root)
        {
            if (root == null) return;

            Stack<GeoNode> stack = new Stack<GeoNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                GeoNode current = stack.Pop();
                history.Add(current);

                for (int i = current.Children.Count - 1; i >= 0; i--)
                {
                    stack.Push(current.Children[i]);
                }
            }
        }

        public bool HasNext
        {
            get
            {
                return currentIndex + 1 < history.Count;
            }
        }
        public bool HasPrevious
        {
            get
            {
                return currentIndex > 0;
            }
        }

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
