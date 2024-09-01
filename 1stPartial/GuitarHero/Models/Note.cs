namespace GuitarHero.Models
{
    /// <summary>
    /// Class <c>Note</c> class to generate notes randomly
    /// </summary>
    public class Note
    {
        readonly private Random rnd = new();
        /// <summary>
        /// Method <c>GenerateRandomNote</c> receive a dictionary to return a random note
        /// </summary> 
        public string GenerateRandomNote(Dictionary<int, string> notes)
        {
            int generatednote = rnd.Next(0, 5);
            return notes.ElementAt(generatednote).Value;
        }
    }
}