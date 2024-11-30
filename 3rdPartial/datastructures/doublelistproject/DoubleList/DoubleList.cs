namespace DoubleList;
using Node;

public class DoubleList<T>
{
    private Node<T>? Start;
    private Node<T>? End;
    private int Count;

    public DoubleList()
    {
        Start = null;
        End = null;
        Count = 0;
    }

    public void Clear()
    {
        Start = null;
        End = null;
        Count = 0;
    }


    public void AddToEnd(T item)
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

    public void AddToStart(T item)
    {
        Node<T> newNode = new(item, Start, null);

        if (Start is null)
        {
            Start = newNode;
            End = newNode;
        }
        else
        {
            Start!.previous = newNode;
            Start = newNode;
        }

        Count++;
    }

    public void RemoveFromEnd()
    {
        if (Start is null)
        {
            WriteLine("The list is empty");
            return;
        }

        if (Start == End)
        {
            Start = null;
            End = null;
        }
        else
        {
            End = End!.previous;
            End!.next = null;
        }

        Count--;
    }

    public void ShowList()
    {
        if (Start is null)
        {
            WriteLine("The list is empty");
            return;
        }

        Node<T>? current = Start;
        while (current is not null)
        {
            WriteLine(current.value);
            current = current.next;
        }
    }

    public int CountList()
    {
        return Count;
    }
}
