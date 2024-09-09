// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Hur gammal var du när du först såg en babian? ");
String Age = Console.ReadLine();
int ålder = int.Parse(Age);
if (ålder <= 2) {
    Console.WriteLine("Du är nog en babian själv");
} else {
   if (ålder <= 9) {
    Console.WriteLine("Du måste ha varit imponerad");
} else {
    if (ålder <= 18) {
    Console.WriteLine("Nu var det nog inte lika intressant");
} else {
    if (ålder <= 50) {
    Console.WriteLine("Du gjorde det nog av egen vilja");
} else {
    Console.WriteLine("Du kan vara glad att du hann se en!");
}
}
} 
}


