using listproject;

SimpleList<int> list = new ();

list.Add(1);
list.Add(2);

list.ShowList();
WriteLine($"The list has {list.CountList()} items");
