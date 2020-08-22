using System;
using Xunit;
using GraphDataStructure;
using System.Linq;
using System.ComponentModel;

namespace GraphImplTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddVertexToGraph()
        {
            // Arrange
            Graph<string, int> graph = new Graph<string, int>();
            // Act

            graph.AddVertex("Washington");

            // Assert
            Assert.NotNull(graph);
        }

        [Fact]
        public void AddDirectedEdge()
        {
            // Arrange
            Graph<string, int> graph = new Graph<string, int>();

            //Act 

            var a = graph.AddVertex("Washington");
            var b = graph.AddVertex("California");

            graph.AddDirectedEdge(a, b, 100);

            var data = graph.AdjacencyList[a].Count;
            var destination = graph.AdjacencyList[a].FirstOrDefault(x => x.Vertex == b);

            Assert.Equal(1, data);
            Assert.Equal(100, destination.Weight);
            Assert.NotNull(destination);
            Assert.NotNull(destination.Vertex);
        }

        [Fact]
        public void AddUndirectedEdge()
        {
            // Arrange
            Graph<string, int> graph = new Graph<string, int>();

            //Act 
            var a = graph.AddVertex("Washington");
            var b = graph.AddVertex("California");

            graph.AddUndirectedEdge(a, b, 50);

            var countA = graph.AdjacencyList[a].Count;
            var countB = graph.AdjacencyList[b].Count;

            var destinationA = graph.AdjacencyList[a].FirstOrDefault(x => x.Vertex == b);
            var destinationB = graph.AdjacencyList[b].FirstOrDefault(x => x.Vertex == a);


            Assert.Equal(1, countA);
            Assert.Equal(1, countB);
            Assert.Equal(50, destinationA.Weight);
            Assert.Equal(50, destinationB.Weight);



        }

        [Fact]
        public void GetNeighbors()
        {
            Graph<string, int> graph = new Graph<string, int>();

            //Act 
            var a = graph.AddVertex("Washington");
            var b = graph.AddVertex("California");
            var c = graph.AddVertex("Texas");


            graph.AddUndirectedEdge(a, b, 50);
            graph.AddUndirectedEdge(a, c, 150);

            var count = graph.AdjacencyList[a].Count;

            Assert.Equal(2, count);

        }
    }
}
