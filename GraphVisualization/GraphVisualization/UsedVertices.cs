using System;
using System.Collections.Generic;
using System.Text;

namespace GraphVisualization
{
    public class UsedVertices
    {
        public UsedVertices() { }
        public bool Validate(Graph g, bool[] listOfVertices, int n, int i, int k)
        {
            if (k > n)
                return false;
            if (!g.validVertex)
            {
                return true;
            }

            if (i == n)
            {
                return g.Validate(listOfVertices, n, k);
            }
            else
            {
                listOfVertices[i] = false;
                Validate(g, listOfVertices, n, i + 1, k);
                if (!g.validVertex)
                {
                    return true;
                }

                listOfVertices[i] = true;
                Validate(g, listOfVertices, n, i + 1, k);
                if (!g.validVertex)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
