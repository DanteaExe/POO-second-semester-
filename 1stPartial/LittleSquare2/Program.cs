using static System.Console;
using LittleSquare2;

char inputKey;
int x = 0, y = 0, intsize;

do
{
    WriteLine("Write the size in number of the square: ");
    string? size = ReadLine();
    intsize = int.Parse(size!);
} while (intsize > 10 || intsize <= 0);

Square square = new(x, y, intsize);

square.Draw();

do
{
    WriteLine("Select 'w' to move up the square, 'a' to move to the left, 'd' to move it to the right and 's' to move it down");
    WriteLine("Or, write 'f' if you want to finish: ");
    inputKey = ReadKey().KeyChar;

    square.Move(inputKey);
    Clear();
    square.Draw();
} while (inputKey != 'f');

WriteLine("See you :3");
