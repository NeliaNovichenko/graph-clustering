using System;
using System.Collections.Generic;
using System.Linq;
using GraphClustering.Algorithms.Abstractions;

namespace GraphClustering.Algorithms.Helpers
{
    class GraphHelpers : IGraphHelpers
    {
        public void TryAddNode(Graph graph, Node node)
        {
            var existingNodes = graph.Nodes.Count(n => n.Id == node.Id || n.Label == node.Label);
            if (existingNodes == 0)
                graph.Nodes.Add(node);
        }

        public List<Node> GetAdjacencyNodes(Graph graph, Node node)
        {
            throw new NotImplementedException();
        }

        public Edge GetEdge(Graph graph, int outNodeId, int inNodeId)
        {
            graph.Edges.Where(e => e.)
        }

        public List<Graph> InitialClastering(Graph graph)
        {
            var clusters = new List<Graph>();
            var visitedNodes = new List<int>();

            foreach (var node in graph.Nodes)
            {
                if (visitedNodes.Contains(node.Id))
                    continue;

                Graph cluster = new Graph();
                var nodesQueue = new Queue<Node>();
                nodesQueue.Enqueue(node);
                visitedNodes.Add(node.Id);

                TryAddNode(cluster, node);

                while (nodesQueue.Count != 0)
                {
                    var queuedNode = nodesQueue.Dequeue();
                    foreach (var adjacencyNode in GetAdjacencyNodes(graph, queuedNode))
                    {
                        if (!visitedNodes.Contains(adjacencyNode.Id))
                        {
                            TryAddNode(cluster, adjacencyNode);
                            Edge e = graph.Edges.FindEdge(v, j);
                            subgraph.CreateLink(v, j, e.Weight);
                            visited[j] = true;
                            Q.Enqueue(j);
                        }
                    }
                }
                cs.Add(subgraph);
            }

        }
    }
}
