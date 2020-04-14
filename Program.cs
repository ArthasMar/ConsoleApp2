using System;
public class Node
{
    public int key;
    public Node next;

    public Node(int x)
    {
        key = x;
    }
}

public class MyQueue
{
    public Node front;
    public Node rear;
    public int Count { get; private set; }

   public void Enqueue(int x)
    {
        var t = new Node(x);
        ++Count;
        if(rear == null)
        {
            front = rear = t;
        }
        rear.next = t;
        rear = t;
    }

    public void Dequeue()
    {
        if (front == null)
            return;

        var t = front;
        front = front.next;

        if (front == null)
            rear = null;
        --Count;
    }
}



    class Program
{
        static void Main(string[] args)
    {
        var q = new MyQueue();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);

        Console.WriteLine(q.front.key);
    }
}

