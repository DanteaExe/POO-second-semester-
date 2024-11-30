namespace Node;

public class Node<T>(T? value, Node<T>? next, Node<T>? previous)
{
    private T? Value = value;
    private Node<T>? Next = next; 
    private Node<T>? Previous = previous;

    public T? value { get => Value; set => Value = value; }
    public Node<T>? next { get => Next; set => Next = value; }
    public Node<T>? previous { get => Previous; set => Previous = value; }
}
