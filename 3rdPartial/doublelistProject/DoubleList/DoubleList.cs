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

    public void Add(T item)
    {
        Start ??= new Node<T>(item, Start, End);
        
        End!.next = new Node<T>(item, Start, End = End.next);
        
        Count++;
    }

    public void Remove(T item)
    {
        if (Start is null)
        {
            return;
        }

        if (Start.value!.Equals(item))
        {
            Start = Start.next;
            Count--;
            return;
        }

        Node<T>? current = Start;
        while (current is not null)
        {
            if (current.next is null)
            {
                return;
            }
        }
    }

    public void ShowList()
    {
        if (Start is null)
        {
            WriteLine("The list is empty");
        }

        while (Start is not null)
        {
            WriteLine(Start.value);
            Start = Start.next;
        }
    }

    public int CountList()
    {
        return Count;
    }
}
