# Queues

### Introduction
What is the purpose of the data structure?
What is the performance of the data structure (you will need to talk about big O notation)?
What kind of problems can be solved using the data structure?
How would the data structure be used in C# (in some cases you will need to discuss recursion)?
What kind of errors are common when using the data structure?


### Grocery Store Queue
    Dequeue: When the item at the front is removed from the queue
    Enqueue: When a new person joins the queue at the back
        Data cannot be entered in the middle of the queue
        Used when we need to process a collection of requests in a fair and orderly way
    Two common queues: Web Server Queue and the Reader/Writer Queue

### Web Server Queue
    When a request is sent, it is put into a queue until the web server can process the request. In this way, all requests are received and none of them are lost
    Queues frequently have a self-imposed maximum size. If a queue is full, then the software may need to send an error message back to the client

### Reader/Write Queue
    Process/thread: the need to run different software components concurrently
    Each process will likely have their own set of variables that are maintained. Frequently, there is need to have shared data between the processes
    A queue is used to ensure order and integrity
    When a process wants to write, it is enqueued. When a process is dequeued, it is then allowed to modify the shared variable
    When the process is done, then the next process is dequeued.

### Running Test Cases
    Testing importance in software development
    Utilizing inline test code in C# for function validation
    Contrasting manual result checking with Trace.Assert for automated assertion and error reporting
    Handling testing complexities, such as setting up scenarios involving multiple function calls
    Testing aids in understanding software requirements
    Role of testing in Continuous Integration/Continuous Deployment (CI/CD) models
    Ensuring software updates don't introduce new issues through rigorous testing
    Automation of assert statements for comprehensive code coverage and efficient testing

### Efficiency of Common Operations



### Example
**Description**
Imagine you are developing a directory structure for a file system. Each directory can contain files and subdirectories. You need to model this hierarchy to perform operations like adding, searching, and displaying the contents.

**Real World Application**
File systems use tree structures to represent directories and files, allowing for efficient organization, retrieval, and manipulation of data. Other applications include organizational charts, hierarchical data management, and navigating XML/HTML documents.

**Identify the Strengths of the Data Structure**
Hierarchical Organization: Represents relationships between elements naturally, such as parent-child relationships.
Efficient Search and Insert: Enables efficient insertion, deletion, and searching of elements.
Flexibility: Can represent a wide range of hierarchical data, from file systems to organizational charts.
How This Applies in Your Given Application
In a file system, using a tree structure allows you to represent the nested hierarchy of directories and files, enabling efficient navigation and management of the data.

**Putting Those Two Things Together**
To model a directory structure, you will use a tree where each node represents a directory or file. This will allow you to add directories/files, search for specific items, and display the structure.

**How to Use the Data Structure to Solve the Problem**
We won't build the tree from scratch. Instead, we'll define a simple tree structure using classes in C# to represent the directory and file hierarchy.

using System;
using System.Collections.Generic;

public class FileSystem
{
    public static void Main(string[] args)
    {
        DirectoryNode root = new DirectoryNode("root");

        // Create subdirectories and files
        DirectoryNode home = new DirectoryNode("home");
        DirectoryNode user = new DirectoryNode("user");
        FileNode file1 = new FileNode("file1.txt");
        FileNode file2 = new FileNode("file2.txt");

        // Build the tree
        root.AddChild(home);
        home.AddChild(user);
        user.AddChild(file1);
        user.AddChild(file2);

        // Display the tree
        Console.WriteLine("Directory Structure:");
        DisplayTree(root, "");

        // Search for a file
        Console.WriteLine("\nSearching for 'file1.txt':");
        var searchResult = Search(root, "file1.txt");
        if (searchResult != null)
        {
            Console.WriteLine($"Found: {searchResult.Name}");
        }
        else
        {
            Console.WriteLine("Not Found");
        }
    }

    // Display the tree structure
    private static void DisplayTree(Node node, string indent)
    {
        Console.WriteLine(indent + node.Name);
        foreach (var child in node.Children)
        {
            DisplayTree(child, indent + "  ");
        }
    }

    // Search for a node by name
    private static Node Search(Node node, string name)
    {
        if (node.Name == name)
        {
            return node;
        }

        foreach (var child in node.Children)
        {
            var result = Search(child, name);
            if (result != null)
            {
                return result;
            }
        }

        return null;
    }
}

// Base class for nodes
public abstract class Node
{
    public string Name { get; }
    public List<Node> Children { get; }

    protected Node(string name)
    {
        Name = name;
        Children = new List<Node>();
    }

    public void AddChild(Node child)
    {
        Children.Add(child);
    }
}

// Directory node class
public class DirectoryNode : Node
{
    public DirectoryNode(string name) : base(name) { }
}

// File node class
public class FileNode : Node
{
    public FileNode(string name) : base(name) { }
}
Add Elements: Directories and files are added to the tree using AddChild.
Display Structure: The directory structure is displayed using a recursive method DisplayTree.
Search: The tree is searched for a specific file or directory using a recursive method Search.



### Problem to Solve: Name
from queue import Queue

def setup_cooking_queue():
    cooking_tasks = Queue()
    # Predefined tasks (the user may add more or modify existing ones)
    tasks = ["Preheat oven to 180°C", "Chop vegetables", "Boil water"]
    for task in tasks:
        cooking_tasks.put(task)
    
    return cooking_tasks

def main():
    cooking_queue = setup_cooking_queue()
    # TO-DO: Implement the task execution logic
    while not cooking_queue.empty():
        task = cooking_queue.get()
        # TO-DO: Implement task handling logic here
        print(f"Task to complete: {task}")
        # User should add code here to mark tasks as done or handle them

if __name__ == "__main__":
    main()


You can check your code with the solution here: [Solution](queues-problem-solution)

Back to [Welcome Page](0-welcome.md)