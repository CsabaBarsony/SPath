using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPath
{
    class Node
    {
        public int id { get; set; }
        public String name { get; set; }
        public List<Edge> edges { get; set; }

        public Node(int id)
        {
            this.id = id;
            this.edges = new List<Edge>();
        }

        public Node(int id, String name)
        {
            this.name = name;
            this.id = id;
            this.edges = new List<Edge>();
        }

        public void addEdge(Edge edge)
        {
            this.edges.Add(edge);
        }
    }
}
