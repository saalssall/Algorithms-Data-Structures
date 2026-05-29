namespace Data_Structures;

/// <summary>
/// A min-heap based Priority Queue.
/// The element with the LOWEST priority value is dequeued first (e.g., priority 1 before priority 5).
/// Internally uses a binary heap stored in an array for O(log n) enqueue/dequeue.
/// </summary>
public class PriorityQueue
{
    // ─── Inner type ────────────────────────────────────────────────────────────

    /// <summary>
    /// A value paired with its priority level.
    /// </summary>
    private struct Node
    {
        public int Value;
        public int Priority;

        public Node(int value, int priority)
        {
            Value = value;
            Priority = priority;
        }
    }

    // ─── Fields ────────────────────────────────────────────────────────────────

    private Node[] heap;       // Backing array (1-indexed; index 0 is unused)
    private int count;         // Number of elements currently in the heap
    private int capacity;      // Maximum number of elements

    // ─── Properties ───────────────────────────────────────────────────────────

    public int Count => count;
    public bool IsEmpty => count == 0;
    public bool IsFull  => count == capacity;

    // ─── Constructor ──────────────────────────────────────────────────────────

    public PriorityQueue(int size)
    {
        capacity = size;
        heap = new Node[capacity + 1]; // +1 because we use 1-based indexing
        count = 0;
    }

    /// <summary>
    /// Adds an element with the given priority.
    /// Lower priority number = higher urgency (min-heap).
    /// Time complexity: O(log n)
    /// </summary>
    public void Enqueue(int value, int priority)
    {
        if (IsFull)
            throw new InvalidOperationException("Priority queue is full.");

        count++;
        heap[count] = new Node(value, priority);

        // Restore heap order by bubbling the new node UP
        BubbleUp(count);
    }

    /// <summary>
    /// Removes and returns the element with the lowest priority number.
    /// Time complexity: O(log n)
    /// </summary>
    public int Dequeue()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Priority queue is empty.");

        int highestPriorityValue = heap[1].Value; // Root always holds the minimum

        // Move the last element to the root, then shrink
        heap[1] = heap[count];
        count--;

        // Restore heap order by pushing the root DOWN
        BubbleDown(1);

        return highestPriorityValue;
    }

    /// <summary>
    /// Returns the front element WITHOUT removing it.
    /// Time complexity: O(1)
    /// </summary>
    public int Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Priority queue is empty.");

        return heap[1].Value;
    }

    // ─── Private helpers ──────────────────────────────────────────────────────

    /// <summary>
    /// After inserting at position i, swap upward while the node is
    /// higher-priority (lower number) than its parent.
    ///
    /// Heap parent/child index relationships (1-based):
    ///   Parent of i  →  i / 2
    ///   Left child   →  i * 2
    ///   Right child  →  i * 2 + 1
    /// </summary>
    private void BubbleUp(int i)
    {
        while (i > 1)
        {
            int parent = i / 2;

            if (heap[i].Priority < heap[parent].Priority)
            {
                Swap(i, parent);
                i = parent;
            }
            else
            {
                break; // Heap property satisfied
            }
        }
    }

    /// <summary>
    /// After placing the last element at the root, swap downward
    /// with the smaller of its two children until heap order is restored.
    /// </summary>
    private void BubbleDown(int i)
    {
        while (true)
        {
            int left  = i * 2;
            int right = i * 2 + 1;
            int smallest = i; // Assume current node is the smallest

            if (left  <= count && heap[left].Priority  < heap[smallest].Priority)
                smallest = left;

            if (right <= count && heap[right].Priority < heap[smallest].Priority)
                smallest = right;

            if (smallest == i)
                break; // Heap property satisfied

            Swap(i, smallest);
            i = smallest;
        }
    }

    /// <summary>Swaps two nodes in the heap array.</summary>
    private void Swap(int a, int b)
    {
        (heap[a], heap[b]) = (heap[b], heap[a]);
    }
}