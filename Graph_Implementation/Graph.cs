using System.Collections;

namespace Graph_Implementation;

public class Graph
{
    Dictionary<int, ArrayList> _adjecencyList;
    public Graph()
    {
        _adjecencyList = new Dictionary<int, ArrayList>();
    }
    public void addVertex(Node node)
    {
        _adjecencyList[node.Number] = new ArrayList { };
    }
    public void addEdge(Node node1, Node node2)
    {
        _adjecencyList[node1.Number].Add(node2.Number);
    }
    public void showConnections()
    {
        foreach (var item in _adjecencyList)
        {
            Console.Write($"{item.Key}->");
            showArrayList(item.Value);
            Console.WriteLine();
        }
    }
    void showArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item+" ");
        }
    }
}
