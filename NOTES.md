# Week 02

## Characteristics of an Algorithm

An algorithm must have:

- **Input** — receives well-defined data
- **Output** — produces a specific result
- **Definiteness** — each step is unambiguous
- **Finiteness** — terminates after finite steps

---

## Big-O Notation

Big-O classifies how algorithms scale as input size increases.

---

## Search Algorithms

### Linear Search
- Brute force search
- Checks each item one by one
- Worst case: `O(n)`

### Binary Search
- More efficient than linear search
- Requires sorted arrays
- Splits data in half repeatedly
- Complexity: `O(log n)`

---

## Sorting Algorithms

### Bubble Sort
- Compares every pair
- Complexity: `O(n²)`

### Merge Sort
- Divide and conquer
- Complexity: `O(n log n)`

### Quick Sort
- Efficient partitioning algorithm

---

## Pseudocode

- Language independent
- Easier to communicate
- Focuses on logic instead of syntax

---

## NP-Complete Problems

NP-complete = **Nondeterministic Polynomial Complete**

---

## Data Structures

### Array
- Fast index access
- Access: `O(1)`

### Linked List
- Fast insertion: `O(1)`
- Slower index access

### Binary Search Tree
- Combines ideas of arrays and linked lists
- Efficient searching

### Hash Table
- Near-instant lookup
- Average lookup: `O(1)`

---

## Stack (LIFO)

**Last In, First Out**

Applications:
- Browser back button
- Undo functionality

---

## Queue (FIFO)

**First In, First Out**

Applications:
- Print job scheduling
- CPU task management

---

## Recursion

### Recursive
- Function calls itself
- Fibonacci example
- May run out of memory

### Iterative
- More code
- Linear complexity: `O(n)`

---

## Cache

Stores calculated results to avoid repeated computation.

---

## Algorithm Design Approaches

### Greedy
- Make locally optimal choices

### Dynamic Programming
- Store subproblem results using cache

### Backtracking
- Try options and undo if stuck

---

## Validating Correctness

- Test edge cases
- Verify known examples
- Check boundary conditions
- Measure large dataset performance

---

## Implementation Tips

- Design in pseudocode first
- Analyse complexity before coding
- Choose suitable data structures
- Profile bottlenecks

---

Algorithms shape what is possible in computing.

---

# Week 03

## Algorithm Complexity Analysis

Goal:
- Understand how input size `n` scales

### Input Size Examples

| Structure | Input Size |
|---|---|
| Array | Number of elements |
| String | Length |
| Graph | Vertices |
| Integer | Number of bits |

---

## Why Count Steps Instead of Seconds?

Because:
- CPU speeds vary
- Compiler optimizations differ
- Background processes affect timing

We need machine-independent measurements.

---

## Loop Analysis

### Single Loop
If runtime depends on `n`, growth scales with `n`.

### Binary Search
Example of logarithmic growth.

### Constant Growth
Execution time stays the same as input increases.

### Cubic Growth
Execution time increases rapidly as input grows.

---

## Complexity Cases

### Best Case
Minimum operations required.

### Worst Case
Maximum operations required.

Used for reliability analysis.

### Average Case
Expected operations for typical input.

---

## Linear Search Analysis

| Case | Comparisons |
|---|---|
| Best | 1 |
| Worst | n |

---

## Big-O Rules

- Keep dominant term only
- Ignore constants and lower-order terms
- Provides upper runtime bound

Example:

$begin:math:display$
3n \\rightarrow O\(n\)
$end:math:display$

---

## Binary Tree
Used in binary search structures.

## Hash Index
Allows direct lookup.

---

## Social Media Feed Example

### Naïve Approach
- Sort all posts
- `O(n \log n)`

### Optimised Approach
- Sort top `k` candidates
- `O(k \log k)`

Pre-filtering reduces work.

---

## Empirical vs Theoretical Analysis

### Empirical
- Measure real performance
- Count operations

### Theoretical
- Mathematical analysis using Big-O

Usually:
1. Theoretical first
2. Empirical second

Large inputs better reveal scalability differences.

---

# Week 04 — Linear Data Structures

## Choosing Data Structures

Important factors:
- Memory efficiency
- Access speed
- Modification speed

---

## Arrays

- Cache-friendly
- Fast access
- Slow modification due to shifting
- Shifting complexity: `O(n)`

---

## Linked Lists

- Nodes scattered in memory
- Connected using pointers
- Dynamic size

---

## Arrays vs Linked Lists

| Feature | Better Choice |
|---|---|
| Cache performance | Arrays |
| Insertion flexibility | Linked Lists |
| Memory efficiency | Arrays |
| Modification flexibility | Linked Lists |

Choose based on access vs modification needs.

---

## Stack

**LIFO — Last In, First Out**

- Operations: `O(1)`
- Only top element accessible

---

## Queue

### Operations
- Enqueue → add to rear
- Dequeue → remove from front

### Characteristics
- First come, first served
- Prevents unfair cutting in line
- Operations: `O(1)`

### Applications
- Printer queues
- Task scheduling

---

## Circular Queue

Rear wraps around when space becomes available.

---

## Hash Tables

- Key-value storage
- Uses computed indices

### Hash Function

$begin:math:display$
\\text\{Key\} \\rightarrow \\text\{Array Index\}
$end:math:display$

### Advantages
- Trades space for speed
- Average lookup: `O(1)`
- Faster than `O(n)` searching

### Good Hash Functions
- Distribute keys evenly
- Prevent collisions and clustering

---

## Collisions

Occurs when two keys hash to the same index.

### Linear Probing
Checks next available slot sequentially.

### Example

$begin:math:display$
\\text\{student\\\_id\} \\rightarrow \\text\{record location\}
$end:math:display$

---

## Load Factor

$begin:math:display$
\\text\{Load Factor\} \= \\frac\{\\text\{elements\}\}\{\\text\{table size\}\}
$end:math:display$

### Low Load (< 0.7)
- Few collisions
- Faster

### High Load (> 0.9)
- More collisions
- Slower

---

## Queue Implementation Guidance

Track:
- Front index
- Rear index
- Enqueue/dequeue operations
- Circular behaviour

---

## Stack Implementation Guidance

### Array-Based Stack
Uses arrays for stack operations.

---

## Quick Sort

### Partitioning
Elements left of pivot do not need full ordering initially.

### Choosing a Pivot
1. Identify first, middle, and last elements
2. Sort the 3 elements
3. Hide pivot before partitioning

# Week 05 — Sorting Algorithms

## Insertion Sort

### Idea
Take an element from the unsorted section and move it into the correct position in the sorted section.

### Process
- Shift larger numbers to the right
- Use a temporary variable to store the value being sorted
- Update values in the array as elements shift

### Steps
1. Move to the next element in the unsorted part
2. Compare it with elements in the sorted part
3. Insert it into the correct position

---

## Selection Sort

### Idea
Find the minimum value and swap it into the correct position.

### Process
- Find the smallest value in the array
- Track the minimum index
- Store the minimum value temporarily
- Swap it with the larger value

### Analogy
Like organizing books by height on a shelf.

### Key Characteristic
- Always scans the entire remaining array

---

## Bubble Sort

### Idea
At each pass, the largest value moves to the end.

### Process
- Compare adjacent elements
- Swap elements when needed
- Let the “bubble” rise to the top each round

### Key Characteristic
- Uses swapping only

---

## Merge Sort

### Idea
Uses divide and conquer.

### Process
1. Divide the list into smaller sublists
2. Continue splitting recursively
3. Sort each sublist independently
4. Merge sorted halves together efficiently

### Key Characteristics
- Recursive algorithm
- Splits the problem in half repeatedly
- Combines sorted results during merging
  
# Week 06

## Big-O Complexity

- When evaluating Big-O complexity, always analyse the **worst-case scenario**

- Worst-case analysis shows how an algorithm behaves under the hardest conditions

---

## Quick Sort

### Pivot Choice

- Pivot selection determines the performance of quicksort

- Good pivot choices improve efficiency

- Poor pivot choices can reduce performance significantly

---

## Stable Algorithms

A stable algorithm:

- Does not reorder duplicate values

---

## Merge Sort

### Characteristics

- Stable sorting algorithm

- Requires additional memory

---

## Randomized Algorithms

### Purpose

- Help avoid bad behaviour

- Reduce chances of poor worst-case performance

---

# Week 07 — Dynamic Programming

## Dynamic Programming
Dynamic programming is the process of optimizing recursive problems that have overlapping subproblems.

It is important to define what the subproblems are before anything else.

Dynamic programming is a kind of divide and conquer.

---

# Overlapping Subproblems

## Subproblem
When a problem is solved by solving smaller versions of the same problem, the smaller problem is called the **subproblem**.

### Fibonacci Example
In the case of Fibonacci numbers, `fib(n-1)` and `fib(n-2)` call many of the same functions as each other, which is what **overlapping subproblems** are all about.

One of the two techniques used to solve overlapping subproblems is **memoization**.

---

# Techniques for Solving Overlapping Subproblems

## 1. Memoization (Top-Down)

### Definition
Memoization reduces recursive calls in cases of overlapping subproblems by remembering previously computed functions.

Start at the problem you want to solve, then solve subproblems as required.

### Advantages
- Stores computed recursive calls in a hash table to avoid recomputation.
- The hash table is passed as the second parameter to functions so they can access stored values.

### Disadvantages
- Memory hungry because of:
  - the call stack
  - the memo table

---

## 2. Bottom-Up

### Definition
- Analyse the problem to determine:
  - which subproblems need to be solved
  - the order in which they should be solved
- Solve subproblems in the required order, building up to the solution of the overall problem.

### Advantages
- Uses loops instead of recursion.
- Faster and uses less memory in many cases.
- Ditches recursion and uses another approach (such as loops) to solve the same problem.

### Disadvantages
- May solve problems that are not required.
- Requires more detailed analysis during design.
---

# Week08 - Substring Search:

## Sunday Algorithm

Sunday's algorithm works similarly to the bad character heuristic, 
but instead of looking at a mismatched character inside the current window, it looks at the character just past the end of the current window. 
It then checks if that character appears in the pattern — if not, skip past it entirely; if yes, shift until it lines up with its rightmost occurrence in the pattern.
- The algorithm uses a dictionary for comparisons

## Characteristics

- Very efficient string searching algorithm

Complexity — best case is O(n/m) when the pattern's characters rarely appear in the text (maximum skips every time), worst case degrades to O(n·m) on highly repetitive text.

### Process

1. Compare the first character

2. Compare the last character

3. Check whether the character exists in the dictionary

4. Subtract its index from `j` to determine movement
  
## Heuristics: 
- A function used in search algorithms to select where to search
- Testing equality backwards as it improves efficiency compared to testing equality forwards
- A technique used to speed up algorithms 

## Bad Character Heuristic:

When a mismatch happens, slide the pattern right until the mismatched text character lines up with the same character in the pattern. If that character doesn't exist in the pattern at all, slide the pattern completely past it.
- A kind of Boyer Moore algorithm

---

## Naive substring search: 
Check every position in the text one by one, and at each position compare the pattern character by character from left to right. If all characters match, you found it. If any character doesn't match, move one position to the right and start over.
No shortcuts, no skips — just brute force.

---

# Week 9 Lecture Notes: Trees, Binary Search Trees, Prefix Trees, DFT & Backtracking

---

## 1. Trees — Overview

Trees appear **everywhere** in computer science. There are (at least) three broad contexts in which you encounter them:

| Context | Description |
|---|---|
| **Data structures** | The tree is the underlying storage mechanism |
| **Decision trees** | A flowchart-style branching structure (yes/no choices, etc.) |
| **Search trees / state spaces** | An implicit tree that models the space of possible decisions |

The common thread is the **branching structure** — what distinguishes a tree from other structures.

---

## 2. Tree Data Structures

### 2.1 When the Data Is Inherently Tree-Shaped

Some data is semantically a tree, so it is natural to store it as one:

- **File systems** — directories contain sub-directories and files; the root is `/` (Linux) or `C:\` (Windows).
- **Process trees** — in operating systems.
- **The DOM** — HTML elements nested inside each other.
- **Syntax trees** — produced when parsing programming languages.
- **GUI elements** — windows contain panels contain buttons, etc. (widgets inside widgets).
- **Class hierarchies** — in most OO languages (not C++, which allows multiple inheritance).

### 2.2 When a Tree Structure Is Chosen for Efficiency

Sometimes the data is **not** inherently a tree, but we store it in one because it gives us fast algorithms for insertion, deletion, and search:

- **Binary Search Trees (BST)**
- **Red-Black Trees**
- **Prefix Trees (Tries)**
- **B-Trees**
- **Merkle Hash Trees** (cryptographic; used in blockchains like Bitcoin/Ethereum to store a compact root hash on-chain while the full data sits off-chain in a Patricia trie)

---

## 3. Tree Terminology

> Think of a **family tree** — the naming conventions are borrowed directly from it.

| Term | Definition |
|---|---|
| **Node** | A single element in the tree, holding data and/or pointers to other nodes |
| **Children** | Nodes that a given node points to |
| **Parent** | The node that points to a given node |
| **Root** | The unique node with **no parent**; every other node has exactly one parent |
| **Leaf** | A node with **no children** |
| **Ancestors** | All nodes on the path from a node up to (and including) the root |
| **Descendants** | All nodes reachable by following pointers downward from a node |
| **Path** | The unique sequence of nodes from the root to any given node |
| **Depth** | The number of edges from the root to a node (root has depth 0) |
| **Height** | The maximum depth across all nodes in the tree |
| **Degree** | The maximum number of children any node is allowed to have |
| **Subtree** | Any node together with all of its descendants forms a subtree rooted at that node |

### Key properties
- There is a **unique path** from the root to every node.
- The root is at **depth 0**; its children are at depth 1; their children at depth 2; and so on.
- For a **binary tree**, degree = 2 (each node has at most a left child and a right child).
- For a **ternary tree**, degree = 3.

### Subtrees are powerful
The subtree concept is why we can think recursively. When you copy or move a directory in a file system, you naturally move the whole subtree — everything it contains — not just a single node. The same mental model applies when you're designing recursive algorithms on trees.

---

## 4. Binary Search Trees (BSTs)

### 4.1 Motivation

| Structure | Fast insert/delete? | Fast search? |
|---|---|---|
| Array | ✗ (shifting required) | ✓ (binary search on sorted array) |
| Linked list | ✓ (once position is known) | ✗ (must traverse linearly) |
| **BST** | ✓ | ✓ |

BSTs aim for the **best of both worlds**.

### 4.2 Structure

Each node stores:
- A **key** (must be orderable — e.g. integers, strings)
- A **value**
- A **left** child pointer (or `null`)
- A **right** child pointer (or `null`)

### 4.3 The Binary Search Tree Property

> For **every** node with key `k`:
> - All keys in the **left subtree** are **less than** `k`.
> - All keys in the **right subtree** are **greater than** `k`.

This must hold recursively at every node. It is the analogue of having a sorted array — it tells you which side to search.

**Example tree (root = 6):**

```
           6
         /   \
        4     8
       / \   / \
      2   5 7   9
     / \
    1   3
```

Reading the leaves left-to-right: 1, 2, 3, 4, 5, 6, 7, 8, 9 — always increasing.

### 4.4 Search Algorithm

Start at the root. At each node, three cases:

1. **Key equals node key** → found; return the value.
2. **Key < node key** → recurse into the **left** subtree.
3. **Key > node key** → recurse into the **right** subtree.
4. **Null node reached** → key is not in the tree.

This is naturally recursive. In C# / C-style pseudocode:

```csharp
private string? SearchSubtree(Node? node, string key)
{
    if (node == null) return null;           // empty subtree — not found

    return string.Compare(key, node.Key) switch
    {
        0    => node.Value,                  // found
        < 0  => SearchSubtree(node.Left,  key),  // go left
        > 0  => SearchSubtree(node.Right, key),  // go right
    };
}
```

### 4.5 Insert

Insertion works similarly to search: descend the tree following the BST property until you reach a `null` slot, then place the new node there. (Full implementation covered in the tutorial.)

### 4.6 Delete

Deletion is more complex (three cases depending on whether the node has 0, 1, or 2 children). The implementation is provided for reference but not assessed in detail.

### 4.7 Complexity

#### Balanced tree

For a **perfectly balanced** binary tree with `L` levels:

- Nodes storable: `2^L - 1`
- Search cost: `L` comparisons
- Since `N ≈ 2^L`, then `L = log₂(N)`

∴ **Average-case search: O(M log N)**, where M is key length (for string comparisons).

#### Unbalanced tree — worst case

If you insert keys **in sorted order** (e.g. 1, 2, 3, 4, …), the BST degenerates into a linked list — every node only has a right child. In this case:

- **Worst-case search: O(M·N)**

This is a `N`-fold degradation from the average case and is a real-world risk (e.g. if your data is already sorted before insertion).

**Fix:** randomise insertion order. Or use a self-balancing tree.

### 4.8 Self-Balancing Trees (overview)

- **Red-Black Trees** — maintain a "colour" bit per node to track balance; perform rotations (pivots) on insert/delete to keep the tree balanced.
- **B-Trees** — optimised for disk-based storage (e.g. databases). Minimise head seeks on spinning disks by keeping reads sequential. Higher degree than 2.

### 4.9 Use Cases for BSTs

- Key-value stores (dictionaries / HashMaps)
- Sets
- Priority queues

---

## 5. Prefix Trees (Tries)

> Name: "trie" (from re**trie**val), pronounced like "try" but spelled T-R-I-E.

### 5.1 What Is a Prefix Tree?

A prefix tree stores **string data** (or sequences). Each node represents **a single character**. Following the path from the root to any node spells out a prefix; following it to a leaf (or a specially marked node) spells out a complete stored word.

- Unlike a BST, each node can have **up to 26 children** (one per letter of the alphabet, or more generally one per symbol in the alphabet).

### 5.2 Example

Storing: `cat`, `cab`, `dog`, `dry`

```
        root
       /    \
      C      D
      |     / \
      A    O   R
     / \   |   |
    T   B  G   Y
```

- root → C → A → T : "cat" (leaf)
- root → C → A → B : "cab" (leaf)
- root → D → O → G : "dog" (leaf)
- root → D → R → Y : "dry" (leaf)

**Subtlety:** To store "do" alongside "dog", you need an end-of-word marker on the O node. Without it you cannot distinguish "do" from the prefix "do" within "dog".

### 5.3 Algorithms

Searching, inserting, and deleting all work the same way: at each step, take the next character of the string and descend to the corresponding child. No comparisons between whole strings — just one hop per character.

### 5.4 Complexity

| Operation | BST | Prefix Tree |
|---|---|---|
| Search | O(M log N) | **O(M)** |
| Insert | O(M log N) | **O(M)** |
| Delete | O(M log N) | **O(M)** |

Where `M` = length of the string, `N` = number of stored strings.

**Key insight:** The cost is **independent of N** — it doesn't matter how many strings are stored. You always pay only the length of the string you're looking for.

### 5.5 Other Advantages

- **No rebalancing required.** Every string has a unique, predefined location in the trie. Insertion order doesn't matter.
- **Space efficiency with shared prefixes.** "cat" and "cab" share the C and A nodes — those characters are stored only once. In a BST, the full string would be duplicated in each node.

### 5.6 Variants

- **Compressed tries / Patricia tries** — if a node has only one child, collapse the path. E.g. C → A can become a single node "CA". Faster traversal, less memory.
- **Patricia trie + Merkle hashing** = structure used in many blockchains.

---

## 6. Depth-First Traversal (DFT / DFS)

### 6.1 What Is Traversal?

**Traversal** means visiting every node in a tree exactly once. It is foundational for tasks such as:

- Scanning all files for viruses
- Finding and modifying all HTML elements in a DOM
- Printing all keys stored in a tree

### 6.2 Depth-First Traversal

**Depth-first traversal (DFT)** / **Depth-first search (DFS)** works as follows:

```
DFT(node):
    if node is null: return
    process(node)           ← do whatever you need with this node
    for each child of node:
        DFT(child)
```

**Why "depth-first"?** The first thing the algorithm does is keep descending — root → first child → first grandchild → … → leaf — before it ever backtracks to look at a sibling. It visits an **entire subtree** before moving to the next sibling.

**Contrast with breadth-first traversal (BFT):** BFT visits all children of the current level before descending. DFT goes deep first; BFT goes wide first.

### 6.3 Example on the Prefix Tree

Calling DFT on the tree containing `cat`, `cab`, `dog`, `dry`:

```
Visit order:
1. root
2. C
3. A
4. B  ← leaf: "cab" found
5. T  ← leaf: "cat" found
6. D
7. O
8. G  ← leaf: "dog" found
9. R
10. Y ← leaf: "dry" found
```

The key insight is that by the time you reach a leaf, you have naturally accumulated the entire word along the path (e.g. you remember C → A → B as you descended).

---

## 7. State Spaces

### 7.1 What Is a State Space?

Many algorithms work by **assigning values to parameters one at a time**. Each assignment is a choice, and there could have been other choices. This naturally creates a **tree of choices** — the **state space** (or search tree).

- The **root** = no parameters assigned yet.
- Each **level** of the tree = choosing a value for the next parameter.
- Each **node** = a partial assignment so far.
- A **leaf** = all parameters assigned (a complete candidate solution).
- A **path** from root to a node = the partial (or complete) assignment of parameters made so far.

> **Important:** The state space tree is usually **not explicitly stored** anywhere in memory. It is an abstract model of the structure of your algorithm. Trees don't have to be physically present — they can be an analytical or conceptual tool.

### 7.2 Examples of State Spaces

- **Tic-tac-toe:** root = empty board; each level = one player making a move; branches = the set of legal moves available at that point.
- **Sudoku:** root = given puzzle; each level = filling in one more cell; branches = valid digits to try.
- **N-Queens:** root = empty board; each level = placing one queen; branches = which column to place it in.

---

## 8. Backtracking Algorithms

**A backtracking algorithm = DFT applied to a state space.**

The name comes from the act of **undoing a partial assignment** when it leads to a dead end and returning (backtracking) to try a different branch.

**Concrete example (prefix tree string building):**
- Build string incrementally as you descend: add a character at each node.
- When you reach a leaf, you have a complete word — process it.
- When you backtrack (return from the recursive call), **remove** the last character you added.
- This "undo" step is the backtracking.

---

## 9. Pruning

Traversing the entire state space can be very expensive. **Pruning** means recognising early that a particular subtree **cannot contain a useful solution** and skipping it entirely.

### 9.1 General Pruning

At any node, check whether continuing is worthwhile. If not, return immediately without visiting the subtree.

**Example — Sudoku:** As soon as any row, column, or box contains a repeated digit, prune. There is no point filling in the remaining cells.

**Example — game trees:** If the opponent has already won, stop — there is nothing useful below this node.

### 9.2 Branch and Bound (Pruning for Optimisation)

Used when searching for a **minimum (or maximum) cost** solution:

1. Track the **best cost found so far** (`bestCost`).
2. At each node, use a **heuristic to estimate a lower bound** on the best cost achievable from this node downward.
3. If `lowerBound ≥ bestCost`, **prune** — this subtree cannot beat what you already have.

**Critical requirement on the heuristic:** It must be **admissible** — it must **never overestimate** the true cost. Overestimating could cause you to prune a branch that actually contains the optimal solution. Underestimating is safe (you just prune less).

---

## 10. The N-Queens Problem

### 10.1 Problem Statement

Given an N×N chessboard, place N queens such that **no two queens attack each other**.

A queen attacks any piece in the same **row**, **column**, or **diagonal** (any of 8 directions).

- For N=3, no solution exists.
- For all N ≥ 4, solutions exist.

**Variant (harder — NP-complete):** Given a board with some queens already placed, determine whether additional queens can be placed to satisfy the non-attacking constraint.

### 10.2 Simplification

Since no two queens can share a row, and there are N rows and N queens, **place exactly one queen per row**. This constrains the problem to:

- Parameters: `Q[0], Q[1], …, Q[N-1]` where `Q[i]` = column of the queen in row `i`.
- Each `Q[i]` ∈ {0, 1, …, N-1}.
- Total candidates without constraints: `N^N` (much better than naïvely placing anywhere on the board).

### 10.3 Attack Conditions (Code-Level)

Two queens at positions `(i, j)` and `(k, l)` are attacking if any of:

| Condition | Meaning |
|---|---|
| `j == l` | Same column |
| `k - i == l - j` | Same diagonal (top-left → bottom-right) |
| `i - k == l - j` | Same anti-diagonal (top-right → bottom-left) |

### 10.4 State Representation

```csharp
int[] state;   // state[i] = column of queen in row i
int param;     // number of queens placed so far (= next row to fill)
```

### 10.5 Backtracking Algorithm with Pruning

```csharp
bool Solve(int[] state, int param, int n)
{
    // Pruning: check if current partial placement is valid
    if (param > 0 && !ConstraintsSatisfied(state, param - 1))
        return false;

    // Base case: all queens placed
    if (param == n)
        return true;

    // Try each column for the queen in row `param`
    for (int col = 0; col < n; col++)
    {
        state[param] = col;
        if (Solve(state, param + 1, n))
            return true;   // solution found
    }

    return false;   // no column worked — backtrack
}
```

**Where pruning happens:** `ConstraintsSatisfied` is called immediately after placing each queen. If the latest queen conflicts with any previous queen, the call returns `false` and we stop descending — the entire subtree for that choice is skipped.

### 10.6 State Tree for 3-Queens (Illustration)

```
                   (empty)
           /          |          \
        Q0=0         Q0=1        Q0=2
          |         /    \         |
       Q1=? [pruned]    [pruned] Q1=?
       ...                       ...
```

- Many branches are pruned early when two queens are found to be attacking each other.
- For N=3: every complete branch is either pruned or found to have no valid Q2 — confirming no solution exists.

### 10.7 Complexity

- **Naïve brute force:** O(N!) to enumerate all permutations.
- **With pruning:** Still O(N!) in the **worst case** (some pathological inputs prevent pruning), but **dramatically faster on average** — most branches are cut early.

This mirrors the BST situation: worst case is much worse than average case, but for typical inputs, performance is excellent.

---

## 11. Summary Table

| Topic | Key Idea |
|---|---|
| BST | Binary search property; O(M log N) average search; O(MN) worst case if unbalanced |
| Prefix tree | One node per character; O(M) search independent of N; no rebalancing; space-efficient for shared prefixes |
| DFT / DFS | Go deep before going wide; visit entire subtree before sibling |
| State space | Implicit tree of algorithm choices; not necessarily stored in memory |
| Backtracking | DFT on a state space; undo partial assignments on return |
| Pruning | Skip subtrees that cannot lead to valid/optimal solutions |
| Branch & bound | Pruning for optimisation using an admissible lower-bound heuristic |
| N-Queens | Classic backtracking + pruning problem; one queen per row; prune on first constraint violation |

---

*Lecture transcript — Week 9, CAB301 Algorithms and Complexity.*

# Week10/11 - Graphs/Shortest Path Algorithm:

## Graph: 
A graph is a data structure that specializes in relationships, as it easily conveys how data is connected.
A graph may have nodes that form what is known as a cycle, that is, nodes that reference each other circularly.

### Distinction between trees and graphs: 
- All trees are graphs but not all graphs are trees
- Graphs should not have cycles 
- Every node in the tree is connected to another node in the tree

### Vertex: 
What we referred to as nodes in trees
### Edges: 
The lines between nodes (vertices)
### Neighbours: 
Vertices connected by an edge are adjacent to each other
### Connected graph: 
All vertices are connected in some way
### Path: 
The specific sequence of edges to get from one vertex to another

## Graph Search: 
Checking whether a vertex is connected to another vertex in the graph.

## Graph search usages:
- Checking connection between two vertices
- Searching for a particular vertex within a connected graph
- Traversing a graph

### Note: 
We need to keep track of verti8cies we have visited so far

## Depth-first search algorithm: 
Start at a vertex, add it to the hash table, and visit its adjacent vertices. Then, ignore if the adjacent vertices has been visited, otherwise perform depth-first search recursively on the vertex

## Breadth-First Search: 
Start at the starting vertex, add it to the hash table and queue, and start a loop that runs as long as the queue is not empty. Then, remove the current vertex from the queue, iterate over all its adjacent vertices, ignore if it is visited already, otherwise save it to the queue and the hash table. Repeat until the queue is empty. 

## Breadth-First Search vs. Depth-First search algorithms: 

Breadth-first search traverses all the vertices closest to the starting vertex before moving farther away.

- Needs a lot of memory 
- We go down based on levels or layers 
- Useful for discovering distances: count the number of layers you are away from a vertex 
- Exponential complexity

First-depth search immediately moves as far away from the starting vertex as it can. Only when the search hits a dead end does it return back to the starting vertex.
- Helps you to reach leaves faster if you are interested in leaves
- Good if you do not care about the order because it requires less memory

Choosing BFS or DFS depends on whether we want to stay close to the starting vertex. 
BFS is good for staying close while DFS is good for moving farther away quickly

## Priority queue
- Deletion and insertion are like classic queues, but insertions are similar to ordered arrays.
- We always ensure the data remains sorted in a specific order when we insert data 
- We always want to access the value with the greatest priority.

## Binary heaps
- A data structure that serves as a more efficient foundation for the priority queue 
- Address the O(N) insertions problem caused by priority queues

A specific type of binary tree and must follow two conditions:
1. Heap condition: the value of each node must be greater than each of its descendants nodes
2. Completeness: the tree must be complete

## Min heap
 Each node must contain a smaller value than any of its descendants
## Max heap
 The value of each node must be greater than each of its descendants nodes

## Completeness of trees
- All nodes exist. All of the nodes are there from left to right. However, the bottom row can have empty positions, as long as there aren’t any nodes to the right of these empty positions 
- A heap’s last node is the rightmost node in its bottom level.

# Week12 - Complexity Theory:

Focuses on the intrinsic nature of the problem and how hard it is
In complexity theory, we make lots of simplifying assumptions that make our comparisons easier

**Polynomial time** : P is the set of decision problems solvable in polynomial time.
- It allows us to focus on the underlying problem instead of the specific of problems 
- Polynomials are closed under multiplication 
- P is considered the easy problem by complexity theorists 
- P is problems you could solve in polynomial time

**Nondeterministic polynomial time**: a set of problems where you can verify the answer in polynomial time

Often in NP, we look for the witness not just the answer

A witness is a solution to an optimization problem that proves you can achieve a certain cost or better.
The decision problem version asks: "Can I do at least this good?" — which can be verified quickly if someone shows you a valid solution (the witness).
This is the core idea of NP — you may not be able to find the solution quickly, but if someone gives you one, you can verify it quickly.

The relationship between P and NP is suspected but not proven.
Many problems seem to require exponential time to solve in the worst case — but no one has ever mathematically provedthat any of these problems can't be solved faster.
Example — Factoring large numbers:
Everyone believes there's no fast (polynomial time) algorithm for it
It's the basis of modern encryption
But no one has ever proved it's impossible
This is why P vs NP remains one of the greatest unsolved problems in computer science — we strongly suspect P ≠ NP, but we can't prove it.

**Reduction**: solving problems by transforming it into different type of problem





