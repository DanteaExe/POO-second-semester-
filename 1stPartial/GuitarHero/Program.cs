using static System.Console;
using GuitarHero.Models;

Map map = new();
Game game = new();


Clear();
game.Play();
map.Guitar();
map.AreaDelimiter();
WriteLine();