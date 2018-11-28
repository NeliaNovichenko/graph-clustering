using System.Collections.Generic;

namespace GraphClustering.Algorithms.Abstractions
{
    public class Graph
    {
        public int Id { get; set; }

        public List<Node> Nodes { get; set; }

        public List<Edge> Edges { get; set; }
    }
}
