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
        private List<Vertex> Vertices { get; set; }
        private List<Edge> Edges { get; set; }
        public Dictionary<string, List<string>> AdjacencyList { get; private set; }
        public int[,] AdjacencyMatrix { get; private set; }

        public Graph(bool isDirectGraph)
        {
            IsDirectGraph = isDirectGraph;

            Vertices = new List<Vertex>();
            Edges = new List<Edge>();

            AdjacencyMatrix = new int[0, 0];
            AdjacencyList = new Dictionary<string, List<string>>();
        }

        #region GraphPrivateMethods
        private int GetVertexIndexInVertices(string vertexName)
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

        private void UpdateAdjacencyMatrix()
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
                int row = Vertices.IndexOf(edge.Predecessor);
                int col = Vertices.IndexOf(edge.Successor);

                AdjacencyMatrix[row, col] += 1;

                if (!IsDirectGraph)
                    AdjacencyMatrix[col, row] += 1;
            }
        }
        #endregion

        #region VetexMethods
        public bool AddVertex(string name)
        {
            foreach (var vertex in Vertices)
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
        }

        public bool RemoveVertex(string vertexName)
        {
            int vertexIndex = GetVertexIndexInVertices(vertexName);

            if (vertexIndex != -1)
            {
                Vertices.RemoveAt(vertexIndex);

                AdjacencyList.Remove(vertexName);
                UpdateAdjacencyMatrix();

                return true;
            }

            return false;
        }

        public List<string> GetAllVerticesNames()
        {
            List<string> names = new List<string>();

            foreach (var vertex in Vertices)
            {
                names.Add(vertex.Name);
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
                if (!IsDirectGraph) AdjacencyList[successorVertex.Name].Add(predecessorVertex.Name);

                UpdateAdjacencyMatrix();

                return true;
            }

            return false;
        }

        public bool AddEdge(string predecessorVertexName, string successorVertexName)
        {
            return AddEdge(Vertices[GetVertexIndexInVertices(predecessorVertexName)], Vertices[GetVertexIndexInVertices(successorVertexName)]);
        }
        #endregion

        #region VertexClass
        private class Vertex
        {
            public string Name { get; set; }
            public Vertex(string name)
            {
                Name = name;
            }
        }
        #endregion

        #region EdgeClass
        private class Edge
        {
            public string Name { get; set; }
            public Vertex Predecessor { get; set; }
            public Vertex Successor { get; set; }

            public Edge(string name, Vertex predecessor, Vertex successor)
            {
                Name = name;
                Predecessor = predecessor;
                Successor = successor;
            }
        }
        #endregion
    }
}
