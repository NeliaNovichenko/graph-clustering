using System;
using System.Collections.Generic;
using GraphClustering.Algorithms.Abstractions;

namespace GraphClustering.Algorithms
{
    public class GirvanNewmanClustering: IGraphClustering
    {
        private Graph _original;

        public List<Graph> FindClusters(Graph graph)
        {
            _original = graph;
            throw new NotImplementedException();
        }
    }
}
