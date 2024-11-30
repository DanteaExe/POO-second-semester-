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

WriteLine();
list.AddToStart("Greetings");
list.ShowList();
WriteLine(list.CountList());

list.Clear();

list.ShowList();
WriteLine(list.CountList());