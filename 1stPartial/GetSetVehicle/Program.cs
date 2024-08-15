using static System.Console;
using GetSetVehicle;

#region first object

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

