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

    public void AddAtEnd(T item)
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

    public void AddFirst(T item)
    {
        Node<T> newNode = new(item, null, null);

        if (Start is null)
        {
            Start = newNode;
            End = newNode;
        }
        else
        {
            newNode.next = Start;
            Start = newNode;
        }

        Count++;
    }

    public void AddToNthPosition(int position, T item)
    {
        if (position < 0 || position > Count)
        {
            WriteLine("Invalid position");
            return;
        }

        if (position == 0)
        {
            AddFirst(item);
            return;
        }

        if (position == Count)
        {
            AddAtEnd(item);
            return;
        }

        Node<T> newNode = new(item, null, null);
        Node<T>? current = Start;

        for (int i = 0; i < position - 1; i++)
        {
            current = current!.next;
        }

        newNode.next = current!.next;
        current!.next = newNode;

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
