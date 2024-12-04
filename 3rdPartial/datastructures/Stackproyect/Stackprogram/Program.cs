using Stack;

StackN<int> stack = new();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(6);

stack.ShowStack();
WriteLine($"The stack has: {stack.CountStack()} items");

stack.Pop();
stack.Pop();
stack.Pop();

WriteLine();

stack.ShowStack();
WriteLine($"The stack has: {stack.CountStack()} items");


stack.Clear();
stack.ShowStack();
WriteLine($"The stack has: {stack.CountStack()} items");