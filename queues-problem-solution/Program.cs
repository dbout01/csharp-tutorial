using System;

class QueueNode
{
    public int Data;
    public QueueNode Next;

    public QueueNode(int data)
    {
        Data = data;
        Next = null;
    }
}

class Queue
{
    private QueueNode front;
    private QueueNode rear;

    public Queue()
    {
        front = rear = null;
    }

    // Method to add an item to the queue
    public void Enqueue(int data)
    {
        QueueNode newNode = new QueueNode(data);
        if (rear == null)
        {
            front = rear = newNode;
            return;
        }
        rear.Next = newNode;
        rear = newNode;
    }

    // Method to remove an item from the queue
    public int Dequeue()
    {
        if (front == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        int data = front.Data;
        front = front.Next;
        if (front == null)
        {
            rear = null;
        }
        return data;
    }

    // Method to check if the queue is empty
    public bool IsEmpty()
    {
        return front == null;
    }

    // Method to display the elements of the queue
    public void DisplayQueue()
    {
        QueueNode current = front;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        Console.WriteLine("Enter numbers to add to the queue (type 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }

            if (int.TryParse(input, out int data))
            {
                queue.Enqueue(data);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer or 'done' to finish.");
            }
        }

        Console.WriteLine("Elements in the queue:");
        queue.DisplayQueue();

        Console.WriteLine("Dequeueing elements:");
        while (!queue.IsEmpty())
        {
            Console.WriteLine("Dequeued: " + queue.Dequeue());
        }
    }
}
