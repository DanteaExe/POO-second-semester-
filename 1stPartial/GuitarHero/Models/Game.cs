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
        readonly Note note = new();
        private readonly Dictionary<int, string> notes = new(){
            {1, "Q"},
            {2, "W"},
            {3, "E"},
            {4, "R"},
            {5, "T"}
        };
        private static string[] notesGenerated = [];
        /// <summary>
        /// Method <c>Play</c> Play a song and start playing
        /// </summary>
        public void PlaySong()
        {
            string noteGen = note.GenerateRandomNote(notes);
            for (int i = 0; i < map.GetMapEndY(); i++)
            {
                map.Guitar();
                map.AreaDelimiter();
                map.WriteAt(noteGen, 8, i);
                map.WriteAt(note.GenerateRandomNote(notes), 16, i - 3);
                map.WriteAt(note.GenerateRandomNote(notes), 20, i - 12);
                map.WriteAt(note.GenerateRandomNote(notes), 58, i - 3);
                Sleep(1000); //seconds
                Clear();
            }
        }
    }
}