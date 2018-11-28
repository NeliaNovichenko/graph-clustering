namespace GraphClustering.Graph.Abstractions
{
    public class Edge
    { 
        public int Id { get; set; }

        public int Weight { get; set; }

        public int EndpointNodeId { get; set; }

        public int StartpointNodeId { get; set; }

    }
}
