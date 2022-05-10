using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GraphVisualization
{
    public class Graph
    {
        private Random randomNr = new Random();
        private List<List<int>> adjList;
        private int vertices;
        private List<int> Pendants = new List<int>();
        private List<int> Tops = new List<int>();
        private List<int> IsolatedVertices = new List<int>();
        public bool validVertex { get; set; } = true;

        public int getVertices()
        {
            return this.vertices;
        }

        public List<List<int>> GetListOfConnecteVertices()
        {
            return adjList;
        }

        public Graph(int vertex, int p)
        {
            this.vertices = vertex;
            adjList = new List<List<int>>();

            for (int i = 0; i < vertex; i++)
            {
                adjList.Add(new List<int>());
            }
            this.ConnectionProbabilities(p);
        }

        public bool AddConnection(int v1, int v2)
        {
            if (adjList[v1].Contains(v2) || v1 == v2)
            {
                return false;
            }
            adjList[v1].Add(v2);
            adjList[v2].Add(v1);
            return true;

        }

        public void ConnectAllVertices()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = i + 1; j < vertices; j++)
                {
                    AddConnection(i, j);
                }
            }
        }

        public void ConnectionProbabilities(int p)
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = i + 1; j < vertices; j++)
                {
                    int probability = randomNr.Next(1, 101);
                    if (probability <= p)
                    {
                        AddConnection(i, j);
                    }
                }
            }
        }

        public bool Validate(bool[] listOfVertices, int n, int k)
        {
            if (!validVertex)
            { return true; }

            int count = 0;

            for (int i = 0; i < listOfVertices.Length; i++)
            {
                if (listOfVertices[i] == true)
                {
                    count++;
                }
            }

            bool IsReached = true;
            if (count == k)
            {
                for (int i = 0; i < listOfVertices.Length; i++)
                {
                    for (int j = 0; j < adjList[i].Count; j++)
                    {
                        if ((listOfVertices[i] == false) && (listOfVertices[adjList[i][j]] == false))
                        {
                            IsReached = false;
                            return false;
                        }
                    }
                }
            }
            else
            {
                IsReached = false;
                return false;
            }

            if (IsReached)
            {
                validVertex = false;
            }

            return IsReached;
        }
        public void RecursiveKernalization(int k)
        {
            Pendants.Clear();
            Tops.Clear();
            IsolatedVertices.Clear();
            FindPendants(0, 0);
            FindTops(k, 0);
            FindIsolated(0);
        }
        public void FindPendants(int vertice, int pendantNum)
        {
            bool ok = true;
            int pendantNr = pendantNum;
            if (adjList[vertice].Count == 1)
            {
                if (!Pendants.Contains(vertice))
                {
                    if (ok)
                    {
                        Pendants.Add(vertice);
                    }
                    if (adjList[vertice].Count == 1)
                    {
                        if (!Pendants.Contains(vertice))
                        {
                            if (adjList[pendantNr].Contains(vertice))
                            {
                                ok = false;
                                pendantNr++;
                            }
                        }
                    }
                }
            }
            if (vertice < vertices - 1)
            {
                vertice++;
                FindPendants(vertice, pendantNr);
            }
        }

        public void FindTops(int k, int j)
        {
            if (adjList[j].Count > k)
            {
                if (!Tops.Contains(j))
                {
                    Tops.Add(j);
                }
            }
            if (j < vertices - 1)
            {
                j++;
                FindTops(k, j);
            }
        }

        public void FindIsolated(int vertice)
        {
            if (adjList[vertice].Count == 0)
            {
                if (!IsolatedVertices.Contains(vertice))
                {
                    IsolatedVertices.Add(vertice);
                }
            }
            if (vertice < vertices - 1)
            {
                vertice++;
                FindIsolated(vertice);
            }
        }

        public void updateDotFile()
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {
                fileStream = new FileStream("abc.dot", FileMode.Open, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);


                streamWriter.WriteLine("graph my_graph { node[fontname = Arial, style = \"filled,setlinewidth(4)\",shape = circle]");

                for (int i = 0; i < adjList.Count; i++)
                {
                    if (Tops.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#ca7feb\"]");
                    else if (Pendants.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#7fceeb\"]");
                    else if (IsolatedVertices.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#9beb7f\"]");
                    else
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\"]");
                }

                for (int i = 0; i < adjList.Count; i++)
                {
                    for (int j = 0; j < adjList[i].Count; j++)
                    {
                        if (adjList[i][j] >= i)
                        {
                            streamWriter.WriteLine("node" + i + "--" + "node" + adjList[i][j]);
                        }
                    }
                }

                streamWriter.WriteLine("}");

            }
            catch (System.IO.IOException)
            {
                throw;
            }
            catch (Exception e)
            {
                //throw;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

        }
        public bool RemoveEdge(int src, int dest)
        {
            if (adjList[src].Contains(dest) && adjList[dest].Contains(src))
            {
                adjList[src].Remove(dest);
                adjList[dest].Remove(src);
                return true;
            }
            return false;
        }

        public void TopIncrement(int k)
        {
            for (int i = 0; i < vertices; i++)
            {
                if (adjList[i].Count <= k)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjList[i].Count <= k)
                        {
                            AddConnection(i, j);
                        }
                    }
                    if (!Tops.Contains(i))
                    {
                        Tops.Add(i);
                    }
                    break;
                }
            }
        }

        public void TopDecrement(int k)
        {
            for (int i = 0; i < vertices; i++)
            {
                if (adjList[i].Count > k)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjList[j].Count > k)
                        {
                            RemoveEdge(i, j);
                        }
                    }
                    if (Tops.Contains(i))
                    {
                        Tops.Remove(i);
                    }
                    break;
                }
            }
        }

        public void PendantIncrement()
        {
            for (int i = 0; i < vertices; i++)
            {
                if (adjList[i].Count > 1)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjList[j].Count > 1)
                        {
                            RemoveEdge(i, j);
                        }
                    }
                    if (!Pendants.Contains(i))
                    {
                        Pendants.Add(i);
                    }
                    break;
                }
            }
        }

        public void PendantDecrement()
        {
            for (int i = 0; i < vertices; i++)
            {
                if (adjList[i].Count == 1)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (adjList[j].Count == 1)
                        {
                            AddConnection(i, j);
                        }
                    }
                    if (Pendants.Contains(i))
                    {
                        Pendants.Remove(i);
                    }
                    break;
                }
            }
        }

        public List<List<int>> RemovingNonRelevantVertices()
        {
            List<List<int>> relevantVertices = new List<List<int>>();
            relevantVertices = adjList;
            for (int i = 0; i < vertices; i++)
            {
                if (IsolatedVertices.Contains(i))
                {
                    if (relevantVertices[i].Count != 0)
                    {
                        relevantVertices[i].Clear();
                    }
                }
                if (Pendants.Contains(i))
                {
                    if (relevantVertices[i].Count != 0)
                    {
                        relevantVertices[i].Clear();
                    }
                }
                if (Tops.Contains(i))
                {
                    if (relevantVertices[i].Count != 0)
                    {
                        relevantVertices[i].Clear();
                    }
                }
            }
            return relevantVertices;
        }

        public int GetNewNonRelVerticesK(List<List<int>> relevantVertices, int k)
        {
            if(relevantVertices.Count != 0)
            {
                for (int i = 0; i < vertices; i++)
                {
                    if (Tops.Contains(i))
                    {
                        k--;
                    }
                }
            }
            return k;
        }

        public string ToString(bool NonRelevant)
        {
            string s = "";
            if (NonRelevant)
            {
                for (int i = 0; i < vertices; i++)
                {
                    s += "    node" + i + " [ label = \"" + i + "\" " + VerticesColours(i) + "]\n";
                }
            }
            else
            {
                for (int i = 0; i < vertices; i++)
                {
                    s += "    node" + i + " [ label = \"" + i + "\" " + "color=\"#fa0505\" " + "]\n";
                }
            }
            for (int i = 0; i < vertices; i++)
            {
                for (int j = i + 1; j < vertices; j++)
                {
                    if (adjList[i].Contains(j) && adjList[j].Contains(i))
                    {
                        s += "    node" + i + " -- node" + j + " [ " + "color=green" + "]\n";
                    }
                }
            }
            return s;
        }

        private string VerticesColours(int i)
        {
            string s = "";
            if (Pendants.Contains(i) == true)
            {
                s += "color= \"#eb348c\" ";
            }
            else if (IsolatedVertices.Contains(i) == true)
            {
                s += "color= \"#34a4eb\" ";
            }
            else if (Tops.Contains(i))
            {
                s += "color= \"#ebc634\" ";
            }
            else if (adjList != null)
            {
                if (adjList[i].Count != 0)
                {
                    s += "color= \"#34ebb1\"";
                }
            }
            return (s);
        }


    }
}
