// Converts the given celsius into Fahrenheit
Console.Clear();
Console.WriteLine("This program will convert between celsius and Fahrenheit");
Console.Write("Celcius or Fahrenheit? C/F: ");
string unit = Console.ReadLine();
if (unit == "c"){
    Console.Clear();
    Console.WriteLine("This program will convert the given celsius into Fahrenheit");
// Enter Celcius
Console.Write("Celcius: ");
double tempCelsius = double.Parse(Console.ReadLine());

// Converts to Fahrenheit
double tempFahrenheit = tempCelsius * 9 /5 +32;

// Write Results
Console.WriteLine($"{tempCelsius}C° = {tempFahrenheit}F°");
} else {
    Console.Clear();
    Console.WriteLine("This program will convert the given Fahrenheit into celsius");

    // Enter Fahrenheit
Console.Write("Fahrenheit: ");
double tempFahrenheit = double.Parse(Console.ReadLine());

// Converts to Celsius
double tempCelsius = (tempFahrenheit - 32) * 5 / 9;

// Write Results
Console.WriteLine($"{tempFahrenheit}F° = {tempCelsius}C°");
}
