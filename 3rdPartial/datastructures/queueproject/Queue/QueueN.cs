using Node;

namespace queueproject;

//FIFO, fist in first out
public class QueueN<T>
{
    private Node<T>? Start;
    private Node<T>? End;
    private int Count;

    public QueueN()
    {
        Start = null;
        End = null;
        Count = 0;
    }

    public void Clear()
    {
        WriteLine("Where did the queue go?");
        Start = null;
        End = null;
        Count = 0;
    }

    public void Enqueue(T item)
    {
        Node<T> newNode = new(item, null, End);

        if (Start is null)
        {
            Start = newNode;
            End = newNode;
        }
        else
        {
            End!.next = newNode;
            End = newNode;
        }

        Count++;
    }

    public void Dequeue()
    {
        if (Start is null)
        {
            WriteLine("The queue is empty");
            return;
        }

        Start = Start.next;
        if (Start is not null)
        {
            Start.previous = null;
        }
        else
        {
            End = null;
        }
        
        Count--;
    }

    public void ShowQueue()
    {
        if (Start is null)
        {
            WriteLine("The queue is empty");
            return;
        }

        Node<T>? current = Start;
        while (current is not null)
        {
            WriteLine(current.value);
            current = current.next;
        }
    }

    public int CountQueue()
    {
        return Count;
    }
}
