﻿namespace DoubleList;
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
        Node<T> newNode = new(item, null, End);

        if (Start is null)
        {
            Start = newNode;
            End = newNode;
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
        }

        End = End!.previous;
        End!.next = null;


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
