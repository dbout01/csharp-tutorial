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
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    // Method to perform in-order traversal of the binary tree
    public void InOrder()
    {
        InOrderRec(Root);
    }

    // Recursive method to perform in-order traversal of the binary tree
    private void InOrderRec(Node root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.Write(root.Data + " ");
            InOrderRec(root.Right);
        }
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
