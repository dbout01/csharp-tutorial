using System;
using System.Collections.Generic;

class MySet
{
    private List<int> elements;

    public MySet()
    {
        elements = new List<int>();
    }

    // Method to add an element to the set
    public void Add(int data)
    {
        if (!elements.Contains(data))
        {
            elements.Add(data);
        }
    }

    // Method to remove an element from the set
    public void Remove(int data)
    {
        elements.Remove(data);
    }

    // Method to check if the set contains an element
    public bool Contains(int data)
    {
        return elements.Contains(data);
    }

    // Method to display the elements of the set
    public void DisplaySet()
    {
        foreach (var element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        MySet mySet = new MySet();
        Console.WriteLine("Enter numbers to add to the set (type 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            if (int.TryParse(input, out int data))
            {
                mySet.Add(data);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer or 'done' to finish.");
            }
        }

        Console.WriteLine("Elements in the set:");
        mySet.DisplaySet();

        Console.WriteLine("Enter numbers to remove from the set (type 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            if (int.TryParse(input, out int data))
            {
                mySet.Remove(data);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer or 'done' to finish.");
            }
        }

        Console.WriteLine("Elements in the set after removals:");
        mySet.DisplaySet();
    }
}
