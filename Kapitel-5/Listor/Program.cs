// Använda listor för att skapa/hantera samlingar
Console.Clear();

// Lista på trevliga frukter, tex "ÄPPLE", "APELSIN", "ANANAS"
List<string> frukter = ["äpple", "apelsin", "ananas"];

Console.WriteLine($"Min fruktlista: {frukter[0]},{frukter[1]},{frukter[2]}");

// Ändra i listan
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]},{frukter[1]},{frukter[2]}");

// Gå igenom listan = loopa igenom = från första till sista
foreach (var frukt in frukter)
{
Console.WriteLine(frukt);
}

// Skapa en lista på valfri sak (4st)
// Skriv ut varje sak på samma rad
List<string> nice = ["vatten", "frisk vind", "kall dusch", "regnsmatter", "god sömn"];
foreach (var thing in nice)
{
    Console.Write($"{thing}, ");
}
Console.Clear();





List<string> namnlista = [];
// While-loop
while(true)
{
    Console.Write("Ange ett namn: ");
        string namn = Console.ReadLine();
    namnlista.Add(namn);

// skriv ut listan
foreach (var name in namnlista)
{
Console.WriteLine(name);
}

}