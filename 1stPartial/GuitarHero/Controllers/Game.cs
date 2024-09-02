using static System.Console;
using static System.Threading.Thread;

namespace GuitarHero.Controllers
{
    /// <summary>
    /// Class <c>Game</c> class to handle all related to the game.
    /// Something important to say: the distributions of notes are never the same
    /// because are generated randomly, that means that songs are not repetitive. 
    /// </summary>
    public class Game : DrawInConsole
    {
        private readonly Map map = new();
        private readonly Note note = new();
        private static readonly int notesPerLevel = 20;
        private static readonly string[] notesGenerated = new string[notesPerLevel];
        private static int currentNoteIndex = 0;
        /// <summary>
        /// Method <c>Play</c> Play a song (daaaaah)
        /// This shit was fucking difficult D:
        /// </summary>
        public void PlaySong(int difficulty)
        {
            map.Score = 0;
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
                        //make note "disapear"
                        map.WriteAt(" ", i, y);
                        currentNoteIndex++;
                        //note starts appearing at: 
                        i = 5;
                    }
                }
                i++;
                //50 easy, 25 medium, 10 hard as fuck
                Sleep(difficulty); // in MS, basically how hard is this motherfucker
                Clear();
            }
        }
        //No more documentation because is very tired D:
        public static void ShowMainMenu()
        {
            WriteLine("1.- Play a song");
            WriteLine("2.- Exit");
        }
        public static void ShowDifficultyMenu()
        {
            WriteLine("1.- I'm too young to die");
            WriteLine("2.- Hurt me plenty");
            WriteLine("3.- play a really heavy motherfucker :3 UwU O.o");
        }
        public static void ShowIstructions()
        {
            WriteLine("First things firts... ");
            WriteLine("You have a valid area where you have to make sure you click the note in that area To increas your score.");
            WriteLine("Make sure you click the correct note");
            WriteLine("If the note goes after the valid area you loose ");
            WriteLine("The valid notes are: Q, W, E, R, T");
            WriteLine("Have fun :D");
            WriteLine("Press any key to continue...");
            ReadLine();
        }
    }
}
