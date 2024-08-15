using static System.Console;

namespace GetSetComputer
{
    public class Computer
    {
        public string? MotherBoard { get; set; }
        public bool IsGamer { get; set; }
        private int RAM { get; set; }
        private int HardDrive { get; set; }
        public string? GPU { get; set; }
        private int Batery { get; set; }
        public string? CoolingType { get; set; }
        public int MyProperty { get; set; }

    }
}