using System;
using System.Collections.Generic;
using GraphClustering.Algorithms.Abstractions;

namespace GraphClustering.Algorithms.Helpers
{
    interface IGraphHelpers
    {
        List<Node> GetAdjacencyNodes(Graph graph, Node node);

        List<Graph> InitialClastering(Graph graph);
    }
}
