using static System.Console;
using GetSetVehicle;
using GetSetPerson;
using GetSetComputer;

#region Vehicle object

Vehicle bicycle = new();

WriteLine("Write the color of the vehicle");
string? color = ReadLine();
bicycle.SetColor(color);

WriteLine("Set if is motorized or not");
bicycle.IsMotorized = false;

WriteLine("Set if is expensive or not");
bicycle.IsExpensive = false;

WriteLine("Write the name of the vehicle");
string? name = ReadLine();
bicycle.SetName(name);

WriteLine("Set if is polirized or not");
bicycle.IsPolarized = false;

Vehicle.ShowVehiclestype();
WriteLine("Write the type of the vehicle: ");
string? type = ReadLine();
bicycle.SetType(type);

WriteLine("write year of veichle: ");
string? year = ReadLine();
int intyear = int.Parse(year!);
bicycle.SetYearOfRelease(intyear);

WriteLine("Write the maximum velocity in km per hour o the vehicle: ");
string? velocity = ReadLine();
int intvelocity = int.Parse(velocity!);
bicycle.SetMaxKMPerHour(intvelocity);

WriteLine("Write the number of wheels of the vehicle: ");
string? wheels = ReadLine();
int intwheels = int.Parse(wheels!);
bicycle.SetMaxKMPerHour(intwheels);

WriteLine("Write the number of passengers of the vehicle: ");
string? passengers = ReadLine();
int intpassengers = int.Parse(passengers!);
bicycle.SetMaxKMPerHour(intpassengers);

WriteLine("Set if is robbed or not (do not ask anything xd just... set it)");
bicycle.IsRobbed = false;

WriteLine("Set if is tuned or not");
bicycle.IsTuned = true;

WriteLine("Write the country where the vehicle was frabricated: ");
string? country = ReadLine();
bicycle.SetFabricationCountry(country);

WriteLine("Set if is private or not ");
bicycle.IsPrivate = false;

Vehicle.ShowCategories();
WriteLine("Write the category of the vehicle: ");
string? category = ReadLine();
bicycle.SetCategory(category);

WriteLine();
WriteLine();

WriteLine($"Color: {bicycle.GetColor()}");
WriteLine($"Is motorized: {bicycle.IsMotorized}");
WriteLine($"Is expensive: {bicycle.IsExpensive}");
WriteLine($"Name: {bicycle.GetName()}");
WriteLine($"Is polarized: {bicycle.IsPolarized}");
WriteLine($"Vehicle type: {bicycle.GetVehicleType()}");
WriteLine($"Year of release: {bicycle.GetYearOfRelease()}");
WriteLine($"Max KM per hour: {bicycle.GetMaxKMPerHour()}");
WriteLine($"Number of wheels: {bicycle.GetNumOfWheels()}");
WriteLine($"Number of passengers: {bicycle.GetNumOfPassengers()}");
WriteLine($"Is robbed: {bicycle.IsRobbed}");
WriteLine($"Is tuned: {bicycle.IsTuned}");
WriteLine($"Fabrication country: {bicycle.GetFabricationCountry()}");
WriteLine($"Is private: {bicycle.IsPrivate}");
WriteLine($"Category: {bicycle.GetCategory()}");

#endregion

WriteLine();
WriteLine();

#region Person Object

Person dante = new();

WriteLine("Write the person's name: ");
string? personName = ReadLine();
dante.SetName(personName!);

WriteLine("Write the person's age: ");
string? personAge = ReadLine();
int intAge = int.Parse(personAge!);
dante.SetAge(intAge);

WriteLine("Write the person's hair color: ");
string? personHairColor = ReadLine();
dante.SetHairColor(personHairColor!);

WriteLine("Write the person's RFC: ");
string? rfc = ReadLine();
dante.SetRFC(rfc!);

WriteLine($"Write the person's school level: ");
string? schoolLevel = ReadLine();
dante.SetSchoolLevel(schoolLevel!);

WriteLine("Write W if is a woman or M if is a man: ");
string? sex = ReadLine();
char charSex = char.Parse(sex!);
dante.SetSex(charSex);

WriteLine("Set if is married or not: ");
dante.IsMarried = false;

WriteLine("write his/her hobbie: ");
string? hobbie = ReadLine(); 
dante.Hobbie = hobbie;

WriteLine("Write his/her born country: ");
string? borncountry = ReadLine();
dante.BornCountry = borncountry;

WriteLine("Write his/her living country: ");
string? livingcountry = ReadLine();
dante.LivingCountry = livingcountry;

WriteLine("Write the phone number's person: ");
string? phoneNumber = ReadLine();
int intphoneNumber = int.Parse(phoneNumber!);
dante.SetPhoneNumber(intphoneNumber);

WriteLine("Write the favorite sport: ");
string? favoritesport = ReadLine();
dante.FavoriteSport = favoritesport;

WriteLine("Set if has traveled or not: ");
dante.HasTraveled = true;

WriteLine("Write person's email: ");
string? email = ReadLine();
dante.SetEmail(email!);

WriteLine("Write the favorite song: ");
string? favoritesong = ReadLine();
dante.FavoriteSong = favoritesong;

WriteLine($"Person's name: {dante.GetName()}");
WriteLine($"Person's age: {dante.GetAge()}");
WriteLine($"Person's hair color: {dante.GetHairColor()}");
WriteLine($"Person's RFC: {dante.GetRFC()}");
WriteLine($"Person's school level: {dante.GetSchoolLevel()}");
WriteLine($"Person's age: {dante.GetSex()}");
WriteLine($"Is married: {dante.IsMarried}");
WriteLine($"Person's hbbie: {dante.Hobbie}");
WriteLine($"Person's born cuntry: {dante.BornCountry}");
WriteLine($"Person's living country: {dante.LivingCountry}");
WriteLine($"Person's phone number: {dante.GetPhoneNumber()}");
WriteLine($"Person's favorite sport: {dante.FavoriteSport}");
WriteLine($"Has traveled: {dante.HasTraveled}");
WriteLine($"Person's emaial: {dante.GetEmail()}");
WriteLine($"Person's favorite song: {dante.FavoriteSong}");

#endregion

WriteLine();
WriteLine();

#region Computer Object

Computer macbookair = new();

WriteLine("Write the motherboard that it has: ");
string? motherboard = ReadLine();
macbookair.MotherBoard = motherboard;

WriteLine("Set if is gamer or not: ");
macbookair.IsGamer = false;

WriteLine("Write the ram it has in GB: ");
string? ram = ReadLine();
int intram = int.Parse(ram!);
macbookair.SetRam(intram);

WriteLine("Write how many hard drives you have: ");
string? harddrive = ReadLine();
int intharddrive = int.Parse(harddrive!);
macbookair.SetHardDriveAmount(intharddrive);

WriteLine("Write what GPU has: ");
string? gpu = ReadLine();
macbookair.GPU = gpu;

WriteLine("Write in Mili ampers the battery: ");
string? baterry = ReadLine();
int intbattery = int.Parse(baterry!);
macbookair.SetBattery(intbattery);

WriteLine("Write the cooling type the computer has: ");
string? coolingtype = ReadLine();
macbookair.CoolingType = coolingtype;

WriteLine("Write the release year: ");
string? releaseyear = ReadLine();
int intreleaseyear = int.Parse(releaseyear!);
macbookair.SetReleaseYear(intreleaseyear);

WriteLine("Write the brand: ");
string? brand = ReadLine();
macbookair.Brand = brand;

WriteLine("Set if is expsensive: ");
macbookair.IsExpensive = true;

WriteLine("Write the inches of the computer: ");
string? inches  = ReadLine();
double intinches = double.Parse(inches!);
macbookair.SetInches(intinches);

WriteLine("Write the cost int MX pesos of the computer: ");
string? cost  = ReadLine();
double intcost = double.Parse(cost!);
macbookair.SetCost(intcost);

WriteLine("Write the ports number: ");
string? portsnumber = ReadLine();
int intportsnumber = int.Parse(portsnumber!);
macbookair.SetPortsNumber(intportsnumber);

WriteLine("Write the CPU you have: ");
string? cpu = ReadLine();
macbookair.CPU = cpu;

WriteLine("Write the computer nits: ");
string? nits = ReadLine();
int intnits = int.Parse(nits!);
macbookair.SetNits(intnits);

WriteLine($"The motherboard is: {macbookair.MotherBoard}");
WriteLine($"Is gamer: {macbookair.IsGamer}");
WriteLine($"RAM: {macbookair.GetRam()}");
WriteLine($"Hard drive amount: {macbookair.GetHardDriveAmount()}");
WriteLine($"GPU: {macbookair.GPU}");
WriteLine($"Battery: {macbookair.GetBattery()}");
WriteLine($"Cooling type: {macbookair.CoolingType}");
WriteLine($"Release year: {macbookair.GetReleaseYear()}");
WriteLine($"Brand: {macbookair.Brand}");
WriteLine($"Is expensive: {macbookair.IsExpensive}");
WriteLine($"Inches: {macbookair.GetInches()}");
WriteLine($"Cost: {macbookair.GetCost()}");
WriteLine($"Ports number: {macbookair.GetPortsNumber()}");
WriteLine($"CPU: {macbookair.CPU}");
WriteLine($"Nits: {macbookair.GetNits()}");

#endregion