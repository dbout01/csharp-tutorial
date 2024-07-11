# Trees

### Introduction
Trees in computing are a way to organize data that looks somewhat like a family tree but upside down. The top of the tree is called the root, and it branches out into more nodes (elements) below. In a specific type of tree called a Binary Search Tree (BST), each node keeps smaller values on its left and larger values on its right. This setup allows quick searches, additions, and deletions of nodes, usually taking O(log n) time if the tree is well balanced. This means that operations get slightly slower as the tree grows, but not excessively so. Trees are useful for tasks where data is constantly added and removed, such as managing a dynamically updating list. Common beginner challenges include keeping the tree balanced to maintain efficiency and understanding recursion, which is a concept where a function calls itself to solve problems.


### Binary Trees
Binary Trees
Binary Search Trees
Balanced Binary Search Trees

### Binary Search Trees Operations
Inserting
Traversing
List of operations
    Operation: `Insert(value)`
    - Inserts a value into the tree.
    - Performance: O(log n) - Recursively search the subtrees to find the next available spot.
    Operation: `Remove(value)`
    - Removes a value from the tree.
    - Performance: O(log n) - Recursively search the subtrees to find the value and then remove it, including some cleanup of adjacent nodes.
    Operation: `Contains(value)`
    - Determines if a value is in the tree.
    - Performance: O(log n) - Recursively search the subtrees to find the value.
    Operation: `TraverseForward`
    - Visits all objects from smallest to largest.
    - Performance: O(n) - Recursively traverse the left subtree, then the right subtree.
    Operation: `TraverseReverse`
    - Visits all objects from largest to smallest.
    - Performance: O(n) - Recursively traverse the right subtree, then the left subtree.
    Operation: `Height(node)`
    - Determines the height of a node, using the root if the full tree height is needed.
    - Performance: O(n) - Recursively find the height of the left and right subtrees and return the maximum height (plus one for the root).
    Operation: `Size()`
    - Returns the size of the BST.
    - Performance: O(1) - The size is maintained within the BST class.
    Operation: `Empty()`
    - Returns true if the root node is empty, which can also be determined by checking if the size is 0.
    - Performance: O(1) - The comparison of the root node or the size.

### Efficiency of Common Operations


### Example
* Example description- describe the problem or the requirements and then show the student how to get to the answer
* Real world application
* Identify the strengths of the data structure
* Come up with how this applies in your given application
* Put those 2 things together
* how to use the data structure to solve a problem, not how to build the data structure
```Example code```

### Problem to Solve: Name




















You can check your code with the solution here: [Solution](trees-problem-solution)

Back to [Welcome Page](0-welcome.md)