using static System.Console;

namespace GetSetPerson
{
    public class Person
    {
        private string? Name { get; set; }
        private int Age { get; set; }
        private string? HairColor { get; set; }
        private string? RFC { get; set; }
        private string? SchoolLevel { get; set; }
        private char Sex { get; set; }
        public bool IsMarried { get; set; }
        public string? Hobbie { get; set; }
        public string? BornCountry { get; set; }
        public string? LivingCountry { get; set; }
        private int PhoneNumber { get; set; }
        public string? FavoriteSport { get; set; }
        public bool HasTraveled { get; set; }
        private string? Email { get; set; }
        public string? FavoriteSong { get; set; }

        public string? GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            if(age < 0 || age > 120)
            {
                WriteLine("I do not trust you your that age -_-");
            }
            else
            {
                Age = age;
            }
        }

        public string? GetHairColor()
        {
            return HairColor;
        }
        public void SetHairColor(string haircolor)
        {
            HairColor = haircolor;
        }

        public string? GetRFC()
        {
            return RFC;
        }
        public void SetRFC(string rfc)
        {
            RFC = rfc;
        }

        public string? GetSchoolLevel()
        {
            return SchoolLevel;
        }
        public void SetSchoolLevel(string schoollevel)
        {
            SchoolLevel = schoollevel;
        }

        public char GetSex()
        {
            return Sex;
        }
        public void SetSex(char sex)
        {
            if(sex == 'M' || sex == 'W')
            {
                Sex = sex;
            }
            else
            {
                WriteLine("That's not a valid sex");
            }
        }

        public int GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public void SetPhoneNumber(int phonenumber)
        {
            PhoneNumber = phonenumber;
        }

        public string? GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}