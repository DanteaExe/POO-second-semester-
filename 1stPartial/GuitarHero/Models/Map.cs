namespace GuitarHero.Models
{
    /// <summary>
    /// Class <c>Map</c> creates the videogame map and area delimiters
    /// </summary>
    public class Map : DrawInConsole
    {

        private readonly int MAPSTARTY = 16;
        private readonly int MAPENDY = 21;
        private readonly int MAPENDX = 58;
        /// <summary>
        /// Method <c>GetMapStart</c> gets where the valid area starts(in y) start: 16
        /// </summary>
        public int GetMapStartY()
        {
            return MAPSTARTY;
        }
        /// <summary>
        /// Method <c>GetMapEnd</c> gets where the valid area finishes(in y) end: 21
        /// </summary>
        public int GetMapEndY()
        {
            return MAPENDY;
        }
        /// <summary>
        /// Method <c>GetMapEnd</c> gets where the valid area finishes(in x) end: 58
        /// </summary>
        public int GetMapEndX()
        {
            return MAPENDX;
        }
        /// <summary>
        /// Method <c>AreaDelimiter</c> draws the delimiter where notes are valid.
        /// IMPORTANT, 21 is the map limit-and it starts at 16.
        /// </summary>
        public void AreaDelimiter()
        {
            WriteAt("+----------------------------------------------------------+", 0, MAPSTARTY);
            WriteAt("|                                                          |", 0, 17);
            WriteAt("|                                                          |", 0, 18);
            WriteAt("|                                                          |", 0, 19);
            WriteAt("|                                                          |", 0, 20);
            WriteAt("+----------------------------------------------------------+", 0, MAPENDY);
        }

        /// <summary>
        /// Method <c>Guitar</c> That does not look like a guitar...
        /// </summary>
        public void Guitar()
        {
            for (int i = 0; i < 16; i++)
            {
                WriteAt("|                                                          |", 0, i);
            }
        }
    }
}