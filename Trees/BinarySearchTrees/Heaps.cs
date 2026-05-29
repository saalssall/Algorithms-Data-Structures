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
    
    // Returns the index of the left child of the node at the given index
    private int LeftChildIndex(int index)
    {
        return (index * 2) + 1;
    }

    // Returns the index of the right child of the node at the given index
    private int RightChildIndex(int index)
    {
        return (index * 2) + 2;
    }
    // Accepts an index and calculates the index of its parent node.
    private int ParentIndex(int index)
    {
        return (index - 1) / 2;
    }
    
    
    
}