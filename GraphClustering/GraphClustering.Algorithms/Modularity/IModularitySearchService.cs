using System;
using System.Collections.Generic;
using GraphClustering.Algorithms.Abstractions;

namespace GraphClustering.Algorithms.Modularity
{
    interface IModularitySearchService
    {
        double Calculate(List<Graph> clusters, Graph original);
    }
}
