namespace GuitarHero.Controllers
{
    /// <summary>
    /// Class <c>Note</c> class to generate notes
    /// </summary>
    public class Note
    {
        private readonly Random rnd = new();
        private readonly Dictionary<int, string> notes = new(){
            {1, "Q"},
            {2, "W"},
            {3, "E"},
            {4, "R"},
            {5, "T"}
        };       
        /// <summary>
        /// Method <c>GetNotes</c> Getter for dictionary
        /// </summary>
        public Dictionary<int, string> GetNotes()
        {
            return notes;
        }
        /// <summary>
        /// Method <c>GenerateRandomNote</c> receive a dictionary to return a random note
        /// </summary> 
        public string GenerateRandomNote(Dictionary<int, string> notes)
        {
            int generatednote = rnd.Next(0, 5);
            return notes.ElementAt(generatednote).Value;
        }

        /// <summary>
        /// Method <c>GenerateNotes</c> Generates a single note to display. Save it in an array
        /// </summary>
        public void GenerateNotes(string[] notesGenerated)
        {
            for (int i = 0; i < notesGenerated.Length; i++)
            {
                notesGenerated[i] = GenerateRandomNote(notes);
            }
        }

        /// <summary>
        /// Method <c>GetYPosition</c> Returns the Y position based on the note
        /// </summary>
        public static int GetYPosition(string note)
        {
            return note switch
            {
                "Q" => 3,
                "W" => 6,
                "E" => 9,
                "R" => 12,
                "T" => 15,
                _ => 3,
            };
        }
    }
}