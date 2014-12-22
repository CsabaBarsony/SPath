using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPath
{
    class Edge
    {
        public Node target { get; set; }
        public double weight { get; set; }
        public String name { get; set; }

        public Edge(Node target)
        {
            this.target = target;
        }

        public Edge(Node target, double weight)
        {
            this.target = target;
            this.weight = weight;
        }

        public Edge(Node target, double weight, String name)
        {
            this.target = target;
            this.weight = weight;
            this.name = name;
        }
    }
}
