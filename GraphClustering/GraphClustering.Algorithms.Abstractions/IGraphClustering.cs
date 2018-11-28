using System.Collections.Generic;

namespace GraphClustering.Algorithms.Abstractions
{
    public interface IGraphClustering
    {
        List<Graph> FindClusters(Graph graph);
    }
}
