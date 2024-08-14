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

#region second object

Vehicle privateJet = new();

WriteLine("Write the color of the vehicle");
string? color2 = ReadLine();
privateJet.SetColor(color2);

WriteLine("Set if is motorized or not");
privateJet.IsMotorized = false;

WriteLine("Set if is expensive or not");
privateJet.IsExpensive = true;

WriteLine("Write the name of the vehicle");
string? name2 = ReadLine();
privateJet.SetName(name2);

WriteLine("Set if is polarized or not");
privateJet.IsPolarized = true;

Vehicle.ShowVehiclestype();
WriteLine("Write the type of the vehicle: ");
string? type2 = ReadLine();
privateJet.SetType(type2);

WriteLine("Write year of vehicle: ");
string? year2 = ReadLine();
int intyear2 = int.Parse(year2!);
privateJet.SetYearOfRelease(intyear2);

WriteLine("Write the maximum velocity in km per hour of the vehicle: ");
string? velocity2 = ReadLine();
int intvelocity2 = int.Parse(velocity2!);
privateJet.SetMaxKMPerHour(intvelocity2);

WriteLine("Write the number of wheels of the vehicle: ");
string? wheels2 = ReadLine();
int intwheels2 = int.Parse(wheels2!);
privateJet.SetMaxKMPerHour(intwheels2);

WriteLine("Write the number of passengers of the vehicle: ");
string? passengers2 = ReadLine();
int intpassengers2 = int.Parse(passengers2!);
privateJet.SetMaxKMPerHour(intpassengers2);

WriteLine("Set if is robbed or not (do not ask anything xd just... set it)");
privateJet.IsRobbed = false;

WriteLine("Set if is tuned or not");
privateJet.IsTuned = true;

WriteLine("Write the country where the vehicle was fabricated: ");
string? country2 = ReadLine();
privateJet.SetFabricationCountry(country2);

WriteLine("Set if is private or not");
privateJet.IsPrivate = true;

Vehicle.ShowCategories();
WriteLine("Write the category of the vehicle: ");
string? category2 = ReadLine();
privateJet.SetCategory(category2);

WriteLine();
WriteLine();

WriteLine($"Color: {privateJet.GetColor()}");
WriteLine($"Is motorized: {privateJet.IsMotorized}");
WriteLine($"Is expensive: {privateJet.IsExpensive}");
WriteLine($"Name: {privateJet.GetName()}");
WriteLine($"Is polarized: {privateJet.IsPolarized}");
WriteLine($"Vehicle type: {privateJet.GetVehicleType()}");
WriteLine($"Year of release: {privateJet.GetYearOfRelease()}");
WriteLine($"Max KM per hour: {privateJet.GetMaxKMPerHour()}");
WriteLine($"Number of wheels: {privateJet.GetNumOfWheels()}");
WriteLine($"Number of passengers: {privateJet.GetNumOfPassengers()}");
WriteLine($"Is robbed: {privateJet.IsRobbed}");
WriteLine($"Is tuned: {privateJet.IsTuned}");
WriteLine($"Fabrication country: {privateJet.GetFabricationCountry()}");
WriteLine($"Is private: {privateJet.IsPrivate}");
WriteLine($"Category: {privateJet.GetCategory()}");

#endregion

WriteLine();
WriteLine();

#region third object

Vehicle car = new();

WriteLine("Write the color of the vehicle");
string? color3 = ReadLine();
car.SetColor(color3);

WriteLine("Set if is motorized or not");
car.IsMotorized = false;

WriteLine("Set if is expensive or not");
car.IsExpensive = true;

WriteLine("Write the name of the vehicle");
string? name3 = ReadLine();
car.SetName(name3);

WriteLine("Set if is polarized or not");
car.IsPolarized = true;

Vehicle.ShowVehiclestype();
WriteLine("Write the type of the vehicle: ");
string? type3 = ReadLine();
car.SetType(type3);

WriteLine("Write year of vehicle: ");
string? year3 = ReadLine();
int intyear3 = int.Parse(year3!);
car.SetYearOfRelease(intyear3);

WriteLine("Write the maximum velocity in km per hour of the vehicle: ");
string? velocity3 = ReadLine();
int intvelocity3 = int.Parse(velocity3!);
car.SetMaxKMPerHour(intvelocity3);

WriteLine("Write the number of wheels of the vehicle: ");
string? wheels3 = ReadLine();
int intwheels3 = int.Parse(wheels3!);
car.SetMaxKMPerHour(intwheels3);

WriteLine("Write the number of passengers of the vehicle: ");
string? passengers3 = ReadLine();
int intpassengers3 = int.Parse(passengers3!);
car.SetMaxKMPerHour(intpassengers3);

WriteLine("Set if is robbed or not (do not ask anything xd just... set it)");
car.IsRobbed = false;

WriteLine("Set if is tuned or not");
car.IsTuned = true;

WriteLine("Write the country where the vehicle was fabricated: ");
string? country3 = ReadLine();
car.SetFabricationCountry(country3);

WriteLine("Set if is private or not");
car.IsPrivate = true;

Vehicle.ShowCategories();
WriteLine("Write the category of the vehicle: ");
string? category3 = ReadLine();
car.SetCategory(category3);

WriteLine();
WriteLine();

WriteLine($"Color: {car.GetColor()}");
WriteLine($"Is motorized: {car.IsMotorized}");
WriteLine($"Is expensive: {car.IsExpensive}");
WriteLine($"Name: {car.GetName()}");
WriteLine($"Is polarized: {car.IsPolarized}");
WriteLine($"Vehicle type: {car.GetVehicleType()}");
WriteLine($"Year of release: {car.GetYearOfRelease()}");
WriteLine($"Max KM per hour: {car.GetMaxKMPerHour()}");
WriteLine($"Number of wheels: {car.GetNumOfWheels()}");
WriteLine($"Number of passengers: {car.GetNumOfPassengers()}");
WriteLine($"Is robbed: {car.IsRobbed}");
WriteLine($"Is tuned: {car.IsTuned}");
WriteLine($"Fabrication country: {car.GetFabricationCountry()}");
WriteLine($"Is private: {car.IsPrivate}");
WriteLine($"Category: {car.GetCategory()}");


#endregion