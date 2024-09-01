using static System.Console;
using GuitarHero.Controllers;

Map map = new();
Game game = new();


Clear();
game.PlaySong();
map.Guitar();
map.AreaDelimiter();
WriteLine();