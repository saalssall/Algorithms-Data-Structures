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

# Week09 - Trees:

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





