// BMI program
Console.Clear();
Console.WriteLine("Detta program kommer räkna ut din BMI");

// Ange Kg
Console.Write("Ange din vikt i Kg:");
double kg = double.Parse(Console.ReadLine());

// Ange längd
Console.Write("Ange din längd i M:");
double längd = double.Parse(Console.ReadLine());

// Räkna ut BMI
double BMI = kg / (längd * längd);
Console.WriteLine($"Din BMI är {BMI}");