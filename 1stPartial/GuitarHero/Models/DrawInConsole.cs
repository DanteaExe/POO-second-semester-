using static System.Console;

namespace GuitarHero.Models
{
    /// <summary>
    /// Class <c>DrawInConsole</c> With SetCursorPosition set the position of the cursor.
    /// </summary>
    public abstract class DrawInConsole
    {
        private int OrigRow { get; set; }
        private int OrigCol { get; set; }

        /// <summary>
        /// Method <c>WriteAt</c> needs a string to what is drawn, and an x,y positions
        /// in order to where is going to be drawn the string in the console (where else more? dah).
        /// </summary> 
        public void WriteAt(string characters, int x, int y)
        {
            try
            {
                SetCursorPosition(OrigCol + x, OrigRow + y);
                Write(characters);
            }
            catch (ArgumentOutOfRangeException)
            {
                Clear();
                WriteLine($"Game starts in: {-y}");
            }
        }
    }
}