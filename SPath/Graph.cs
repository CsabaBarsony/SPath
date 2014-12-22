using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPath
{
    class Graph
    {
        public List<Node> nodes { get; set; }

        public Graph(String tgf, bool directed)
        {
            if (directed)
            {
                this.nodes = new List<Node>();
                String[] lines = tgf.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int counter = 0;
                while (lines[counter] != "#")
                {
                    String[] lineParts = lines[counter].Split(' ');
                    this.nodes.Add(new Node(Int32.Parse(lineParts[0])));
                    if (lineParts.Length == 2)
                    {
                        this.nodes.Add(new Node(Int32.Parse(lineParts[0]), lineParts[1]));
                    }
                    counter++;
                }
                counter++;
                while (counter < lines.Length)
                {
                    if (lines[counter] == "") continue;
                    String[] lineParts = lines[counter].Split(' ');

                    int sourceId;
                    int targetId;

                    sourceId = Int32.Parse(lineParts[0]);
                    targetId = Int32.Parse(lineParts[1]);

                    Node source = this.nodes.Find(x => x.id == sourceId);
                    Node target = this.nodes.Find(x => x.id == targetId);
                    Edge e;

                    if (lineParts.Length == 3)
                    {
                        double weight = Double.Parse(lineParts[2]);
                        e = new Edge(target, weight);
                    }
                    else
                    {
                        e = new Edge(target);
                    }

                    source.addEdge(e);
                    counter++;
                }
            }
            else
            {
                this.nodes = new List<Node>();
                String[] lines = tgf.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int counter = 0;
                while (lines[counter] != "#")
                {
                    String[] lineParts = lines[counter].Split(' ');
                    this.nodes.Add(new Node(Int32.Parse(lineParts[0])));
                    if (lineParts.Length == 2)
                    {
                        this.nodes.Add(new Node(Int32.Parse(lineParts[0]), lineParts[1]));
                    }
                    counter++;
                }
                counter++;
                while (counter < lines.Length)
                {
                    if (lines[counter] == "") continue;
                    String[] lineParts = lines[counter].Split(' ');

                    int sourceId;
                    int targetId;

                    sourceId = Int32.Parse(lineParts[0]);
                    targetId = Int32.Parse(lineParts[1]);

                    Node source = this.nodes.Find(x => x.id == sourceId);
                    Node target = this.nodes.Find(x => x.id == targetId);
                    Edge eFromSource, eFromTarget;

                    if (lineParts.Length == 3)
                    {
                        double weight = Double.Parse(lineParts[2]);
                        eFromSource = new Edge(target, weight);
                        eFromTarget = new Edge(source, weight);
                    }
                    else
                    {
                        eFromSource = new Edge(target);
                        eFromTarget = new Edge(source);
                    }

                    source.addEdge(eFromSource);
                    target.addEdge(eFromTarget);
                    counter++;
                }
            }
        }

        public void addNode(Node node)
        {
            this.nodes.Add(node);
            
        }

        public void draw()
        {
            foreach (Node n in this.nodes)
            {
                Console.WriteLine(n.id + " " + n.name);
            }
            Console.WriteLine("#");
            foreach (Node n in this.nodes)
            {
                foreach (Edge e in n.edges)
                {
                    Console.WriteLine(n.id + " " + e.target.id + " " + e.weight + " " + e.name);
                }
            }
        }
    }
}
