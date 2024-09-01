using static System.Console;
using static System.Threading.Thread;

namespace GuitarHero.Models
{
    /// <summary>
    /// Class <c>Game</c> class to handle all related to the game.
    /// Something important to say: the distributions of notes are never the same
    /// because are generated randomly, that means that songs are not repetitive. 
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
                //collocates notes in their specific Y position
                int y = Note.GetYPosition(notesGenerated[currentNoteIndex]);
                //display generated notes
                map.WriteAt(notesGenerated[currentNoteIndex], i, y);

                if (KeyAvailable)
                {
                    //read the input from the user
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    string keyPressed = keyInfo.Key.ToString();
                    //verify if the inpit is a valid note with the dictionary, so score increases
                    if (note.GetNotes().ContainsValue(keyPressed)
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
