namespace MyNamespace;

public class Heap
{
    // Fields
    private List<int> data;

    // Constructor
    public Heap()
    {
        data = new List<int>();
    }

    // Properties
    public int Count => data.Count;
    public bool IsEmpty => data.Count == 0;

    // Returns the root (index 0) — highest priority element
    public int RootNode()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Heap is empty.");

        return data[0];
    }

    // Returns the last element — lowest in the tree
    public int LastNode()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Heap is empty.");

        return data[^1];   // ^1 is C#'s index-from-end operator, equivalent to data[data.Count - 1]
    }
}