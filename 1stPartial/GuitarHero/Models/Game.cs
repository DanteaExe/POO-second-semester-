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
        private static readonly int notesPerLevel = 20;
        private static readonly string[] notesGenerated = new string[notesPerLevel];
        /// <summary>
        /// Method <c>Play</c> Play a song and start playing
        /// </summary>
        public void PlaySong()
        {
            GenerateNotes();
            //for to display notes
            for (int i = 0; i < 35; i++)
            {
                map.Guitar();
                map.AreaDelimiter();
                map.WriteAt("Q", i, 5);
                Sleep(1000);//seconds
                Clear();
            }
        }
        /// <summary>
        /// Method <c>GenerateNotes</c> we generate a single note to display. Do not ask why goes here 
        /// and not in Note class xd
        /// </summary>
        private void GenerateNotes()
        {
            for (int i = 0; i < notesGenerated.Length; i++)
            {
                notesGenerated[i] = note.GenerateRandomNote(notes);
            }
        }
    }
}