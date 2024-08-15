using static System.Console;

namespace GetSetComputer
{
    public class Computer
    {
        public string? MotherBoard { get; set; }
        public bool IsGamer { get; set; }
        private int RAM { get; set; }
        private int HardDriveAmount { get; set; }
        public string? GPU { get; set; }
        private int Battery { get; set; }
        public string? CoolingType { get; set; }
        private int ReleaseYear { get; set; }
        public string? Brand { get; set; }
        public bool IsExpensive { get; set; }
        private double Inches { get; set; }
        private double Cost { get; set; }
        private int PortsNumber { get; set; }
        public string? CPU { get; set; }
        private int Nits { get; set; }

        public int GetRam()
        {
            return RAM;
        }
        public void SetRam(int ram)
        {
            if(ram < 0 || ram > 2000)
            {
                WriteLine("Do you reaaly have that RAM ?!?! :O");
            }
            else
            {
                RAM = ram;
            }
        }

        public int GetHardDriveAmount()
        {
            return HardDriveAmount;
        }
        public void SetHardDriveAmount(int amount)
        {
            if(amount < 0 || amount > 24)
            {
                WriteLine("i do not trust you -_-");
            }
            else
            {
                HardDriveAmount = amount;
            }
        }

        public int GetBattery()
        {
            return Battery;
        }

        public void SetBattery(int battery)
        {
            if(battery < 0 || battery > 4400)
            {
                WriteLine("Yoy can work almost all day if you have that battery");
            }
            else
            {
                Battery = battery;
            }
        }

        public int GetReleaseYear()
        {
            return ReleaseYear;
        }
        public void SetReleaseYear(int year)
        {
            if(year < 1943 || year > 2024)
            {
                WriteLine("Impossible :O");
            }
            else
            {
                ReleaseYear = year;
            }
        }

        public double GetInches()
        {
            return Inches;
        }
        public void SetInches(double inches)
        {
            if(inches < 11 || inches > 100)
            {
                WriteLine("that is too few, or too much, can hurt your see");
            }
            else
            {
                Inches = inches;
            }
        }

        public double GetCost()
        {
            return Cost;
        }
        public void SetCost(double cost)
        {
            if(cost < 0 || cost > 100000)
            {
                WriteLine("Did you really pay that for your pc :O?!?!?! Where?!?!?!!");
            }
            else
            {
                Cost = cost;
            }
        }

        public int GetPortsNumber()
        {
            return PortsNumber;
        }
        public void SetPortsNumber(int portsnumber)
        {
            if(portsnumber < 0 || portsnumber > 10)
            {
                WriteLine("Wy? just... why?");
            }
            else
            {
                PortsNumber = portsnumber;
            }
        }

        public int GetNits()
        {
            return Nits;
        }
        public void SetNits(int nits)
        {
            if(nits < 100 || nits > 600)
            {
                WriteLine("Do you see what you do?");
            }
            else
            {
                Nits = nits;
            }
        }
    }
}