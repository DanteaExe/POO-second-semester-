namespace Stack;
using Node;

public class StackN<T>
{
    private Node<T>? Start;
    private Node<T>? End;
    private int Count;

    public StackN()
    {
        Start = null;
        End = null;
        Count = 0;
    }

    public void Clear()
    {
        WriteLine("The stack got dusted... as we are going to be turned... we burn...we live...and the end we die... like the stack, it just die...");
        Start = null;
        End = null;
        Count = 0;
    }

    public void Push(T item)
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

    public void Pop()
    {
        if (Start is null)
        {
            WriteLine("The stack is empty");
            return;
        }

        if (Start == End)
        {
            Start = null;
            End = null;
        }
        else
        {
            Start = Start!.next;
        }

        Count--;
    }

    public void ShowStack()
    {
        if (Start is null)
        {
            WriteLine("The stack is empty");
            return;
        }

        Node<T>? current = Start;
        while (current is not null)
        {
            WriteLine(current.value);
            current = current.next;
        }
    }

    public int CountStack()
    {
        return Count;
    }
}
