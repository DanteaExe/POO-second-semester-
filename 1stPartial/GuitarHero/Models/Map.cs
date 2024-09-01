namespace GuitarHero.Models
{
    /// <summary>
    /// Class <c>Map</c> creates the videogame map and area delimiters
    /// </summary>
    public class Map : DrawInConsole
    {

        private readonly int MAPSTARTY = 1;
        private readonly int MAPENDY = 16;
        private readonly int MAPSTARTX = 100;
        private readonly int MAPENDX = 117;
        public int Score = 0;
        /// <summary>
        /// Method <c>GetMapStart</c> gets where the valid area starts(in y+1) start: 2
        /// </summary>
        public int GetMapStartY()
        {
            return MAPSTARTY;
        }
        /// <summary>
        /// Method <c>GetMapEnd</c> gets where the valid area finishes(in y-1) end: 16
        /// </summary>
        public int GetMapEndY()
        {
            return MAPENDY;
        }
        /// <summary>
        /// Method <c>GetMapEnd</c> gets where the valid area starts(in x+1) start: 101
        /// </summary>
        public int GetMapStartX()
        {
            return MAPSTARTX;
        }
        /// <summary>
        /// Method <c>GetMapEnd</c> gets where the valid area finishes(in x) start: 117
        /// </summary>
        public int GetMapEndX()
        {
            return MAPENDX;
        }
        /// <summary>
        /// Method <c>AreaDelimiter</c> draws the delimiter where notes are valid.
        /// IMPORTANT, 16 is the map limit and it starts at 2. in y.
        /// in X starts at 100 and finishes at 117
        /// </summary>
        public void AreaDelimiter()
        {
            WriteAt("+-----------------+", MAPSTARTX, MAPSTARTY);
            for (int i = 2; i < MAPENDY; i++)
            {
                WriteAt("|                 |", MAPSTARTX, i);
            }
            WriteAt("+-----------------+", MAPSTARTX, MAPENDY);
        }
        /// <summary>
        /// Method <c>Guitar</c> That looks more like a guitar...
        /// </summary>
        public void Guitar()
        {
            WriteAt("Q", 99, 3);
            WriteAt("W", 99, 6);
            WriteAt("E", 99, 9);
            WriteAt("R", 99, 12);
            WriteAt("T", 99, 15);
            WriteAt($"Score: {Score}", 130, 2);

            for (int i = 20; i < 100; i++)
            {
                WriteAt("-", i, 1);
                //Q, valid area: 3
                WriteAt("-", i, 4);
                //W, valid area: 6
                WriteAt("-", i, 7);
                //E, valid area: 9
                WriteAt("-", i, 10);
                //R, valid area: 12
                WriteAt("-", i, 13);
                //T, valid area: 15
                WriteAt("-", i, 16);
            }
        }
    }
}