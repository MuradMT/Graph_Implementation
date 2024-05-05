namespace Graph_Implementation;

public class Node
{
    object data;
    int number;
    public Node(int Number, object Data)
    {
        number = Number;
        data = Data;
    }
    public object Data 
    {
        get
        {
            return data;
        }
        set
        {
            data = value;
        }
    }
    public int Number
    {
        get
        {
            return number;
        }
    }
}
