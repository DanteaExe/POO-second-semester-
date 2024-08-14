using static System.Console;

namespace GetSetVehicle
{
    public class Vehicle
    {
        private string? Color { get; set; }
        public bool IsMotorized { get; set; }
        public bool IsExpensive { get; set; }
        private string? Name { get; set; }
        public bool IsPolarized { get; set; }
        private string? Type { get; set; }
        private int YearOfRelease { get; set; }
        private int MaxKMPerHour { get; set; }
        private int NumOfWheels { get; set; }
        private int NumOfPassengers { get; set; }
        public bool IsRobbed { get; set; }
        public bool IsTuned { get; set; }
        private string? FabricationCountry { get; set; }
        public bool IsPrivate { get; set; }
        private string? Category { get; set; }

        public string? GetColor()
        {
            return Color;
        }
        public void SetColor(string? color)
        {
            Color = color;
        }

        public string? GetName()
        {
            return Name;
        }

        public void SetName(string? name)
        {
            Name = name;
        }

        public string? GetVehicleType()
        {
            return Type;
        }

        public void SetType(string? type)
        {
            Type = type;
        }

        public static void ShowVehiclestype()
        {
            WriteLine("Land");
            WriteLine("Marine");
            WriteLine("Air");
            WriteLine("Space");
            WriteLine("Animal-drwan");
        }

        public int GetYearOfRelease()
        {
            return YearOfRelease;
        }

        public void SetYearOfRelease(int year)
        {
            if(year < 1886 || year > 2024)
            {
                WriteLine("That's not a valid year");
            }
            else
            {
                YearOfRelease = year;
            }
        }

        public int GetMaxKMPerHour()
        {
            return MaxKMPerHour;
        }

        public void SetMaxKMPerHour(int km)
        {
            if(km < 0 || km > 1227985)
            {
                WriteLine("Thats not a valid velocity");
            }
            else
            {
                MaxKMPerHour = km;
            }
        }

        public int GetNumOfWheels()
        {
            return NumOfWheels;
        }

        public void SetNumOfWheels(int numofwheels)
        {
            if(numofwheels < 1 || numofwheels > 24)
            {
                WriteLine("Do you realy have a new number of wheels record? :O");
            }
            else
            {
                NumOfWheels = numofwheels;
            }
        }

        public int GetNumOfPassengers()
        {
            return NumOfPassengers;
        }

        public void SetNumOfPassengers(int numofpassengers)
        {
            if(numofpassengers < 1 || numofpassengers > 7600)
            {
                WriteLine("I do not trust you have that amount of passengers -_-");
            }
            else
            {
                NumOfPassengers = numofpassengers;
            }
        }

        public string? GetFabricationCountry()
        {
            return FabricationCountry;
        }

        public void SetFabricationCountry(string? country)
        {
            FabricationCountry = country;
        }

        public string? GetCategory()
        {
            return Category;
        }

        public void SetCategory(string? category)
        {
            Category = category;
        }

        public static void ShowCategories()
        {
            WriteLine("M1");
            WriteLine("M2");
            WriteLine("M3");
            WriteLine("N1");
            WriteLine("N2");
            WriteLine("N3");
            WriteLine("L1");
            WriteLine("L2");
            WriteLine("L3");
            WriteLine("L4");
            WriteLine("L5");
        }
    }
}