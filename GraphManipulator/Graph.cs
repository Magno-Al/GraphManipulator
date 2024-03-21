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

        public Graph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public void AddVertex(string name)
        {
            Vertices.Add(new Vertex(name));
        }

        public bool RemoveVertex(string vertexName)
        {
            int selectedIndex = 0;
            bool vertexFound = false;

            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].Name == vertexName)
                {
                    vertexFound = true;

                    selectedIndex = i;
                    i = Vertices.Count;
                }
            }

            if (vertexFound)
            {
                Vertices.RemoveAt(selectedIndex);
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

        public bool AddEdge(string predecessorVertexName, string successorVertexName)
        {
            Vertex tmpPredecessorVertex = new Vertex();
            Vertex tmpSuccessorVertex = new Vertex();

            foreach (var vertex in Vertices)
            {
                if (vertex.Name == predecessorVertexName)
                {
                    tmpPredecessorVertex = vertex;
                }
                if (vertex.Name == successorVertexName)
                {
                    tmpSuccessorVertex = vertex;
                }
            }

            if (tmpPredecessorVertex.Name != null && tmpSuccessorVertex.Name != null)
            {
                Edges.Add(new Edge(tmpPredecessorVertex, tmpSuccessorVertex));
                return true;
            }

            return false;
        }

        //public List<string> GetEdgesByVertex(string name)
        //{
        //    List<string> edgesToReturn = new List<string>();

        //    Vertex tmpVertex = new Vertex();

        //    foreach (var vertex in Vertices)
        //    {
        //        if (vertex.Name == name)
        //        {
        //            tmpVertex = vertex;
        //        }
        //    }

        //    foreach (var edge in Edges)
        //    {
        //        if (edge.Predecessor == tmpVertex)
        //        {
        //            edgesToReturn
        //        }
        //    }
        //}

        public void RemoveEdge(int edgeIndex)
        {
            Edges.RemoveAt(edgeIndex);
        }

        #region VertexClass
        private class Vertex
        {
            public string Name { get; set; }

            public Vertex() { }
            public Vertex(string name)
            {
                Name = name;
            }
        }
        #endregion

        #region EdgeClass
        private class Edge
        {
            public Vertex Predecessor { get; set; }
            public Vertex Successor { get; set; }

            public Edge(Vertex predecessor, Vertex successor)
            {
                Predecessor = predecessor;
                Successor = successor;
            }
        }
        #endregion
    }
}
