using listproject;

SimpleList<int> list = new ();
WriteLine($"The list has {list.CountList()} items");

list.Add(1);
list.Add(2);

list.ShowList();
WriteLine($"The list has {list.CountList()} items");
