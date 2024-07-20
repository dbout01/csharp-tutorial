# Trees

### Introduction
Trees in computing are a way to organize data that looks somewhat like a family tree but upside down. The top of the tree is called the root, and it branches out into more nodes (elements) below. In a specific type of tree called a Binary Search Tree (BST), each node keeps smaller values on its left and larger values on its right. This setup allows quick searches, additions, and deletions of nodes, usually taking O(log n) time if the tree is well balanced. This means that operations get slightly slower as the tree grows, but not excessively so. Trees are useful for tasks where data is constantly added and removed, such as managing a dynamically updating list. Common beginner challenges include keeping the tree balanced to maintain efficiency and understanding recursion, which is a concept where a function calls itself to solve problems.


### Binary Trees
**Binary Trees**
Binary tree = tree that links to no more than two other nodes
![alt text](pictures/trees.png)

**Binary Search Trees**
•	Binary Search Tree (BST) = A binary tree that follows rules for data that is put into the tree
•	By using this process, the data is stored in the tree sorted:
1.	Data is placed into the BST by comparing the data with the value in the parent node
2.	If the data being added is less than the parent node, then it is put in the left subtree
3.	If the data being added is greater than the parent node, then it is put in the right subtree
4.	If duplicates are allowed than the duplicate can be put either to the left or to the right of the root
![alt text](pictures/binary_search_trees.jpg)

**Balanced Binary Search Trees**
- Balanced Binary Search Tree = a BST such that the difference of height between any two subtrees is not dramatically different
    - Height of a tree can be found by counting the maximum number of nodes between root and the leaves. Since it is not reasonable to expect that the order of data will result in a balanced BST, numerous algorithms have been written to detect if a tree is unbalanced and to correct the unbalance
- Algorithms
    - Red Black Trees
    - AVL (Adelson-Velskii and Landis) trees
![alt text](pictures/balanced_bst.jpg)

### Binary Search Trees Operations
**Inserting**
    - Smaller problem: Insert a value into either the left subtree or the right subtree based on the value.
    - Base case: If there is space to add the node (the subtree is empty), then the correct place has been found and the item can be inserted.
    - Two Insert functions: 
        - The first BinarySearchTree.Insert function is the one called by the user who wants to insert a value into the tree. This function is used to call the recursive function Node.Insert on the root node. As a special case, if the root node is empty (null), then we will put the new Node in the root without using any recursion.
        - The second Node.Insert calls itself until it finds an empty position in which to insert the value.

**Traversing**
    - Smaller problem: Traverse the left subtree of a node, use the current node, and then traverse the right subtree of the node.
    - Base case: If the subtree is empty, then don’t recursively traverse or use anything.

**List of Operations**

**Operation: `Insert(value)`**
    - Inserts a value into the tree.
    - Performance: O(log n) - Recursively search the subtrees to find the next available spot.

**Operation: `Remove(value)`**
    - Removes a value from the tree.
    - Performance: O(log n) - Recursively search the subtrees to find the value and then remove it, including some cleanup of adjacent nodes.

**Operation: `Contains(value)`**
    - Determines if a value is in the tree.
    - Performance: O(log n) - Recursively search the subtrees to find the value.

**Operation: `TraverseForward`**
    - Visits all objects from smallest to largest.
    - Performance: O(n) - Recursively traverse the left subtree, then the right subtree.

 **Operation: `TraverseReverse`**
    - Visits all objects from largest to smallest.
    - Performance: O(n) - Recursively traverse the right subtree, then the left subtree.

**Operation: `Height(node)`**
    - Determines the height of a node, using the root if the full tree height is needed.
    - Performance: O(n) - Recursively find the height of the left and right subtrees and return the maximum height (plus one for the root).

**Operation: `Size()`**
    - Returns the size of the BST.
    - Performance: O(1) - The size is maintained within the BST class.

**Operation: `Empty()`**
    - Returns true if the root node is empty, which can also be determined by checking if the size is 0.
    - Performance: O(1) - The comparison of the root node or the size.

### Example
**Description**
Imagine you are developing a family tree application where you need to manage and display the relationships between family members. Each family member can have multiple children, but each child has only one set of parents. You need a data structure to represent this hierarchical relationship efficiently.

**Real World Application**
Managing hierarchical relationships is crucial in many real-world scenarios, such as organizational charts, file systems, or family trees. For instance, in a family tree application, representing each person and their relationships accurately helps in visualizing ancestry, understanding family connections, and performing genealogical research.

**Identify the Strengths of the Data Structure**
- **Hierarchy Representation:** Trees naturally represent hierarchical relationships where each node has children and one parent.
- **Efficient Traversal:** Various tree traversal methods (pre-order, in-order, post-order, level-order) allow efficient navigation through the tree.
- **Simplifies Relationships:** Trees clearly show parent-child relationships, making it easy to understand and manipulate the structure.

**How This Applies in Your Given Application**
For a family tree application, using a tree data structure ensures that each family member is connected properly to their parents and children. This simplifies the management and visualization of family relationships.

**Putting Those Two Things Together**
To manage the family tree for an application, you will use a tree data structure where each node represents a family member, and edges represent parent-child relationships. This ensures an accurate and efficient representation of the family hierarchy.

**How to Use the Data Structure to Solve the Problem**
We won't build the tree from scratch. Instead, we'll use a simple tree structure with nodes to represent family members and demonstrate how to add members and display the family tree.

**Example Code**

```python
class FamilyMember:
    def __init__(self, name):
        self.name = name
        self.children = []

def add_child(parent, child_name):
    child = FamilyMember(child_name)
    parent.children.append(child)
    return child

def print_family_tree(member, level=0):
    print('  ' * level + member.name)
    for child in member.children:
        print_family_tree(child, level + 1)

# Example usage
if __name__ == "__main__":
    # Create the root of the family tree
    root = FamilyMember("Grandparent")
    
    # Add children and grandchildren
    parent1 = add_child(root, "Parent1")
    parent2 = add_child(root, "Parent2")
    
    add_child(parent1, "Child1")
    add_child(parent1, "Child2")
    
    add_child(parent2, "Child3")
    
    # Display the family tree
    print("Family Tree:")
    print_family_tree(root)
```
- Creating FamilyMember Class: Represents a node in the tree with a name and a list of children.
- Adding Children: The `add_child` function adds a new family member as a child to a specified parent and returns the new child node.
- Printing the Family Tree: The `print_family_tree` function recursively prints the family tree, showing the hierarchical relationships with indentation.

### Problem to Solve: Binary Tree Insertion and Traversal
Task: You are required to complete the implementation of a binary tree. This includes writing the code for inserting new nodes into the tree and performing an in-order traversal. Users will test their implementation by inputting numbers to be inserted into the binary tree and then viewing the in-order traversal of the tree.

        using System;

    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Method to insert a new node into the binary tree
        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        // Recursive method to insert a new node into the binary tree
        private Node InsertRec(Node root, int data)
        {
            // TODO: Complete this method to insert a new node into the binary tree
        }

        // Method to perform in-order traversal of the binary tree
        public void InOrder()
        {
            InOrderRec(Root);
        }

        // Recursive method to perform in-order traversal of the binary tree
        private void InOrderRec(Node root)
        {
            // TODO: Complete this method to perform in-order traversal of the binary tree
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Console.WriteLine("Enter numbers to insert into the binary tree (type 'done' to finish):");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    break;
                }

                if (int.TryParse(input, out int data))
                {
                    tree.Insert(data);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or 'done' to finish.");
                }
            }

            Console.WriteLine("Inorder traversal of the given tree:");
            tree.InOrder();
        }
    }


You can check your code with the solution here: [Solution](trees-problem-solution)

Back to [Welcome Page](0-welcome.md)