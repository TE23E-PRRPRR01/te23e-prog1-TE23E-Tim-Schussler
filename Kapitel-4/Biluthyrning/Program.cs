Console.Clear();
Console.WriteLine("WELCOME TO TIM'S AUTO RENTAL");
Console.WriteLine("Base fee: 500$");
Console.Write("5$/Mile ENTER MILES: ");
double miles = double.Parse(Console.ReadLine());
if (miles < 0){
    Console.Clear();
    Console.WriteLine("ERROR");
} else {
Console.Write("100$/Day ENTER DAYS: ");
double days = double.Parse(Console.ReadLine());
if (days < 0){
    Console.Clear();
    Console.WriteLine("ERROR");
} else {
Console.Clear();
double total = ((days * 100) + (miles * 5) + 500);
Console.WriteLine($"Your total cost is {total}$");
}}