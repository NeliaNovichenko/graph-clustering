using System;
using System.Collections.Generic;
using GraphClustering.Algorithms.Abstractions;
using GraphClustering.Algorithms.Helpers;

namespace GraphClustering.Algorithms.Modularity
{
    class ModularitySearchService: IModularitySearchService
    {
        private readonly GraphHelpers _helpers;

        ModularitySearchService(GraphHelpers helpers)
        {
            _helpers = helpers;
        }
        public double Calculate(List<Graph> clusters, Graph original)
        {
            double modularity = 0;
            int numEdge = original.Edges.Count;
            foreach (var graph in clusters)
            {
                int l = 0;
                int d = 0;
                foreach (Node node in graph.Nodes)
                {
                    l += _helpers.GetAdjacencyNodes(graph, node).Count;
                    d += _helpers.GetAdjacencyNodes(original, node).Count;
                }

                l /= 2;

                modularity += ((double)l / numEdge) - Math.Pow(((double)d / (2 * numEdge)), 2);
            }
            return modularity;
        }
    }
}
