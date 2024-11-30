namespace listproject;
using Node;

public class SimpleList<T>
{
    private Node<T>? Start;
    private Node<T>? End;
    private int Count;

    public SimpleList()
    {
        Start = null;
        End = null;
        Count = 0;
    }

    public void Clear()
    {
        WriteLine("The list goes to a better place");
        Start = null;
        End = null;
        Count = 0;
    }

    public void Add(T item)
    {
        Node<T> newNode = new(item, null, null);

        if (Start is null)
        {
            Start = newNode;
            End = newNode;
            Count++;
            return;
        }

        End!.next = newNode;
        End = newNode;

        Count++;
    }


    public void Remove()
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
            return;
        }

        End = End!.next;
        End = null;

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
