using static System.Console;

namespace GuitarHero.Models
{
    public class DrawInConsole
    {
        private int OrigRow { get; set; }
        private int OrigCol { get; set; }
        public void WriteAt(string characters, int x, int y)
        {
            try
            {
                SetCursorPosition(OrigCol + x, OrigRow + y);
                Write(characters);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Clear();
                WriteLine(e.Message);
            }
        }
    }
}