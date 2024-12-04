using queueproject;

QueueN <int>  queue = new ();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

queue.ShowQueue();
WriteLine($"Count:  {queue.CountQueue()}");

WriteLine();

queue.Dequeue();
queue.ShowQueue();
WriteLine($"Count:  {queue.CountQueue()}");


queue.Clear();
queue.ShowQueue();
WriteLine($"Count:  {queue.CountQueue()}");
