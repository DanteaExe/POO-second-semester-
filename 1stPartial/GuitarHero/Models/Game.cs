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
        private static readonly int notesPerLevel = 20;
        private static readonly string[] notesGenerated = new string[notesPerLevel];
        private static int currentNoteIndex = 0;
        /// <summary>
        /// Method <c>Play</c> Play a song (daaaaah)
        /// This shit was fucking difficult D:
        /// </summary>
        public void PlaySong()
        {
            int i = 5;
            note.GenerateNotes(notesGenerated);

            while (currentNoteIndex < notesGenerated.Length)
            {
                if (i is 117)
                {
                    //handle loosing game
                    break;
                }

                map.Guitar();
                map.AreaDelimiter();

                int y = Note.GetYPosition(notesGenerated[currentNoteIndex]);

                map.WriteAt(notesGenerated[currentNoteIndex], i, y);

                if (KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    string keyPressed = keyInfo.Key.ToString();

                    if (keyPressed.Equals(notesGenerated[currentNoteIndex], StringComparison.OrdinalIgnoreCase)
                     && i >= map.GetMapStartX()+1 && i <= map.GetMapEndX()-1)
                    {
                        map.Score++;
                        map.WriteAt(" ", i, y);
                        currentNoteIndex++;
                        i = 5;
                    }
                }
                i++;
                Sleep(50); // in MS
                Clear();
            }
        }
    }
}
