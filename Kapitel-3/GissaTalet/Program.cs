// GISSA HELTALET!!!!!!
using System.Net.Http.Headers;


//Slumpa ett tal
int slumptalet = Random.Shared.Next(1, 1001);
retry:
Console.WriteLine("Guess the secret number between 1-1000");
Console.Write("Guess: ");
//Läs in texten, t.ex "100"
string gissningText = Console.ReadLine();
//Konvertera texten till ett heltal, "100" blir 100
int gissning = int.Parse(gissningText);
Console.Clear();
if (gissning == slumptalet)
{
    Console.WriteLine("Congratulations!");
} else {
if (gissning >= slumptalet)
{
    Console.WriteLine("Too high");
    goto retry;
} else {
Console.WriteLine("Too low");
goto retry;
}
}