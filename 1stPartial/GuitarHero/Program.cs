using static System.Console;
using static System.Threading.Thread;
using GuitarHero.Models;

DrawInConsole map = new();

Clear();

//area delimiter
map.WriteAt("+----------------------------------------------------------+", 0, 16);


for (int i = 0; i < 16; i++)
{
    map.WriteAt("---", 8, i); // shortcut: WriteAt("---", 1, 0)
    Sleep(1000); //seconds
}

map.WriteAt("+----------------------------------------------------------+", 0, 16);
WriteLine();