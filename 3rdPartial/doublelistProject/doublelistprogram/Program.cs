using DoubleList;

DoubleList<string> list = new();

list.Add("Hello");
list.Add("World");
list.Add("!");
list.Add("How");
list.Add("Are");
list.Add("You");

list.ShowList();
WriteLine(list.CountList());

WriteLine();
list.Remove();

list.ShowList();
WriteLine(list.CountList());