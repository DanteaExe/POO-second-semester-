using static System.Console;
using static System.Threading.Thread;

namespace GuitarHero.Models
{
    /// <summary>
    /// Class <c>Game</c> class to handle all related to the game
    /// </summary>
    public class Game : DrawInConsole
    {
        readonly Map map = new();
        /// <summary>
        /// Method <c>Play</c> Play a song and start playing
        /// </summary>
        public void Play()
        {
            for (int i = 0; i < map.GetMapEndY(); i++)
            {
                map.Guitar();
                map.AreaDelimiter();
                map.WriteAt("Q", 8, i);
                map.WriteAt("W", 16, i - 3);
                map.WriteAt("E", 20, i - 12);
                map.WriteAt("R", 20, i - 3);
                Sleep(1000); //seconds
                Clear();
            }
        }
    }
}