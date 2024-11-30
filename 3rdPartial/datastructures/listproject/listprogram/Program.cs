using listproject;

SimpleList<int> list = new ();

list.AddAtEnd(1);
list.AddAtEnd(2);

list.ShowList();
WriteLine($"The list has {list.CountList()} items");

list.AddAtEnd(3);
list.AddAtEnd(4);
list.Remove();
list.AddFirst(5);
list.AddToNthPosition(2, 6);
list.ShowList();

WriteLine($"The list has {list.CountList()} items");
list.Clear();
list.ShowList();