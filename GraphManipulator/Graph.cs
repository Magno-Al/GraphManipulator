using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphManipulator
{
    public class Graph
    {
        public bool IsDirectGraph { get; set; }
        private List<Vertex>? Vertices { get; set; }
        private List<DirectedVertex>? DirectedVertices { get; set; }
        private List<Edge> Edges { get; set; }
        public Dictionary<string, List<string>> AdjacencyList { get; private set; }
        public int[,] AdjacencyMatrix { get; private set; }

        public Graph(int vertices, bool isDirectGraph)
        {
            IsDirectGraph = isDirectGraph;

            if (isDirectGraph)
            {
                DirectedVertices = new List<DirectedVertex>();
            } else
            {
                Vertices = new List<Vertex>();
            }
            
            Edges = new List<Edge>();

            AdjacencyMatrix = new int[vertices, vertices];
            AdjacencyList = new Dictionary<string, List<string>>();

            string alfabeth = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < vertices; i++)
            {
                int div = i / alfabeth.Length;
                int index = i % alfabeth.Length;
                string letter = alfabeth[index].ToString();
                string vertice = letter;
                for (int j = 0; j < div; j++)
                {
                    vertice += letter;
                }
                AddVertex(vertice, isDirectGraph);
            }
        }

        #region GraphPrivateMethods
        private int GetVertexIndexInVertices(string vertexName)
        {
            if (IsDirectGraph)
            {
                if (DirectedVertices is not null)
                {
                    for (int i = 0; i < DirectedVertices.Count; i++)
                    {
                        if (DirectedVertices[i].Name == vertexName)
                        {
                            return i;
                        }
                    }

                    return -1;
                }
                return -1;
            } else
            {
                if (Vertices is not null)
                {
                    for (int i = 0; i < Vertices.Count; i++)
                    {
                        if (Vertices[i].Name == vertexName)
                        {
                            return i;
                        }
                    }

                    return -1;
                }
                return -1;
            }

            
        }

        private void UpdateAdjacencyMatrix()
        {
            if (IsDirectGraph)
            {
                if (DirectedVertices is not null)
                {
                    int directedVertexCount = DirectedVertices.Count;

                    AdjacencyMatrix = new int[directedVertexCount, directedVertexCount];
                    for (int i = 0; i < directedVertexCount; i++)
                    {
                        for (int j = 0; j < directedVertexCount; j++)
                        {
                            AdjacencyMatrix[i, j] = 0;
                        }
                    }

                    foreach (Edge edge in Edges)
                    {
                        // Ta com cara q vai quebrar
                        int row = DirectedVertices.IndexOf(edge.DirectedPredecessor);
                        int col = DirectedVertices.IndexOf(edge.DirectedSuccessor);

                        AdjacencyMatrix[row, col] += 1;

                        if (!IsDirectGraph)
                            AdjacencyMatrix[col, row] += 1;
                    }
                }
            } else
            {
                if (Vertices is not null)
                {
                    int vertexCount = Vertices.Count;

                    AdjacencyMatrix = new int[vertexCount, vertexCount];
                    for (int i = 0; i < vertexCount; i++)
                    {
                        for (int j = 0; j < vertexCount; j++)
                        {
                            AdjacencyMatrix[i, j] = 0;
                        }
                    }

                    foreach (Edge edge in Edges)
                    {
                        // Ta com cara q vai quebrar
                        int row = Vertices.IndexOf(edge.Predecessor);
                        int col = Vertices.IndexOf(edge.Successor);

                        AdjacencyMatrix[row, col] += 1;

                        if (!IsDirectGraph)
                            AdjacencyMatrix[col, row] += 1;
                    }
                }
            }
        }
        #endregion

        #region VetexMethods
        public bool AddVertex(string name, bool isDirectedVertex)
        {
            if (!isDirectedVertex)
            {
                if (Vertices is not null)
                {
                    foreach (Vertex vertex in Vertices)
                    {
                        if (vertex.Name == name)
                        {
                            return false;
                        }
                    }
                    Vertex newVertex = new Vertex(name);
                    Vertices.Add(newVertex);

                    AdjacencyList.Add(newVertex.Name, new List<string>());
                    UpdateAdjacencyMatrix();

                    return true;

                } else
                {
                    return false;
                }
                
            } else {
                if (DirectedVertices is not null)
                {
                    foreach (DirectedVertex vertex in DirectedVertices)
                    {
                        if (vertex.Name == name)
                        {
                            return false;
                        }
                    }
                    DirectedVertex newDirectedVertex = new DirectedVertex(name);
                    DirectedVertices.Add(newDirectedVertex);

                    AdjacencyList.Add(newDirectedVertex.Name, new List<string>());
                    UpdateAdjacencyMatrix();

                    return true;
                } else
                {
                    return false;
                }
                
            }
            

            //Vertex newVertex = new Vertex(name);
            //Vertices.Add(newVertex);

            //AdjacencyList.Add(newVertex.Name, new List<string>());
            //UpdateAdjacencyMatrix();

            //return true;
        }

        public bool RemoveVertex(string vertexName)
        {
            int vertexIndex = GetVertexIndexInVertices(vertexName);

            if (vertexIndex != -1)
            {
                if (IsDirectGraph)
                {
                    if (DirectedVertices is not null)
                    {
                        DirectedVertices.RemoveAt(vertexIndex);

                        AdjacencyList.Remove(vertexName);
                        UpdateAdjacencyMatrix();

                        return true;
                    }
                } else
                {
                    if (Vertices is not null)
                    {
                        Vertices.RemoveAt(vertexIndex);

                        AdjacencyList.Remove(vertexName);
                        UpdateAdjacencyMatrix();

                        return true;
                    }
                }
            }

            return false;
        }

        public List<string> GetAllVerticesNames()
        {
            List<string> names = new List<string>();

            if(IsDirectGraph)
            {
                if(DirectedVertices is not null)
                {
                    foreach (var vertex in DirectedVertices)
                    {
                        names.Add(vertex.Name);
                    }
                }
            } else
            {
                if(Vertices is not null) {
                    foreach (var vertex in Vertices)
                    {
                        names.Add(vertex.Name);
                    }
                }
            }
                    return names;
        }
        #endregion

        #region EdgeMethods
        private bool AddEdge(Vertex predecessorVertex, Vertex successorVertex)
        {
            if (predecessorVertex != null && successorVertex != null)
            {
                string edgeName = "e" + Edges.Count;
                Edges.Add(new Edge(edgeName, predecessorVertex, successorVertex));

                AdjacencyList[predecessorVertex.Name].Add(successorVertex.Name);
                AdjacencyList[successorVertex.Name].Add(predecessorVertex.Name);

                predecessorVertex.degree += 1;
                predecessorVertex.neighborhood.Add(successorVertex);

                successorVertex.degree += 1;
                successorVertex.neighborhood.Add(predecessorVertex);

                UpdateAdjacencyMatrix();


                return true;
            }

            return false;
        }
        private bool AddEdge(DirectedVertex predecessorVertex, DirectedVertex successorVertex)
        {
            if (predecessorVertex != null && successorVertex != null)
            {
                string edgeName = "e" + Edges.Count;
                Edges.Add(new Edge(edgeName, predecessorVertex, successorVertex));

                AdjacencyList[predecessorVertex.Name].Add(successorVertex.Name);

                predecessorVertex.outDegree += 1;
                predecessorVertex.successors.Add(successorVertex);

                successorVertex.inDegree += 1;
                successorVertex.predecessors.Add(predecessorVertex);

                UpdateAdjacencyMatrix();

                return true;
            }

            return false;
        }

        public bool AddEdge(string predecessorVertexName, string successorVertexName)
        {
            if (IsDirectGraph)
            {
                if (DirectedVertices is not null)
                {
                    return AddEdge(DirectedVertices[GetVertexIndexInVertices(predecessorVertexName)], DirectedVertices[GetVertexIndexInVertices(successorVertexName)]);
                }
                return false;
            } else
            {
                if (Vertices is not null)
                {
                    return AddEdge(Vertices[GetVertexIndexInVertices(predecessorVertexName)], Vertices[GetVertexIndexInVertices(successorVertexName)]);
                }
                return false;
            }
        }
        #endregion

        #region VertexClass
        private class Vertex
        {
            public string Name { get; set; }
            public int degree { get; set; }
            public List<Vertex> neighborhood { get; set; }
            public Vertex(string name)
            {
                Name = name;
                degree = 0;
                neighborhood = new List<Vertex>();
            }
        }
        #endregion


        #region DirectedVertexClass
        private class DirectedVertex
        {
            public string Name { get; set; }
            public int inDegree { get; set; }
            public int outDegree { get; set; }
            public List<DirectedVertex> successors { get; set; }
            public List<DirectedVertex> predecessors { get; set; }

            public DirectedVertex(string name)
            {
                Name = name;
                inDegree = 0;
                outDegree = 0;
                successors = new List<DirectedVertex>();
                predecessors = new List<DirectedVertex>();
            }
        }
        #endregion

        #region EdgeClass
        private class Edge
        {
            public string Name { get; set; }
            public Vertex? Predecessor { get; set; }
            public Vertex? Successor { get; set; }
            public DirectedVertex? DirectedPredecessor { get; set; }
            public DirectedVertex? DirectedSuccessor { get; set; }

            public Edge(string name, Vertex predecessor, Vertex successor)
            {
                Name = name;
                Predecessor = predecessor;
                Successor = successor;
            }

            public Edge(string name, DirectedVertex predecessor, DirectedVertex successor)
            {
                Name = name;
                DirectedPredecessor = predecessor;
                DirectedSuccessor = successor;
            }
        }
        #endregion
    }
}
