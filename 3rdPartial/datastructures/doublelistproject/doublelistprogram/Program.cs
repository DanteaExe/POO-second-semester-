using DoubleList;

DoubleList<string> list = new();

list.AddToEnd("Hello");
list.AddToEnd("World");
list.AddToEnd("!");
list.AddToEnd("How");
list.AddToEnd("Are");
list.AddToEnd("You");

list.ShowList();
WriteLine(list.CountList());

WriteLine();
list.RemoveFromEnd();

list.ShowList();
WriteLine(list.CountList());
