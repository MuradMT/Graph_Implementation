namespace Graph_Implementation;

internal class Program
{
    static void Main(string[] args)
    {
        var graph = new Graph();
        var node0 = new Node(0, "hi");
        var node1 = new Node(1, "hello world");
        var node2 = new Node(2, "slm");
        var node3 = new Node(3, "hello");
        var node4 = new Node(4, "privet");
        graph.addVertex(node0);
        graph.addVertex(node1);
        graph.addVertex(node2);
        graph.addVertex(node3);
        graph.addVertex(node4);
        graph.addEdge(node0, node1);
        graph.addEdge(node0, node2);
        graph.addEdge(node1, node3);
        graph.addEdge(node1, node0);
        graph.addEdge(node2, node0);
        graph.addEdge(node2, node3);
        graph.addEdge(node3, node1);
        graph.addEdge(node3, node2);
        graph.addEdge(node4, node3);
        graph.showConnections();
        Console.ReadLine();
    }
}
