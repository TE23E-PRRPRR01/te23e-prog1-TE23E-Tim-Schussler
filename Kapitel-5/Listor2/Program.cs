Console.Clear();
Console.WriteLine("Allt om listor");

// Skapa en tom lista
List<string> listaNamn = [];
List<string> actionSpel = [];
// Infoga i en lista

listaNamn.Add("Alex");  // Verb
listaNamn.Add("Alexander");
Console.WriteLine($"Antal: {listaNamn.Count}");

// Skriv ut listan (går inte)
Console.WriteLine($"Lista: {listaNamn}");

// Skriv ut lista mha loop
foreach (var namn in listaNamn)
{
    Console.WriteLine($"- {namn}");
}

// Första elementet i listan (index = 0)
Console.WriteLine($"Första elementet {listaNamn[0]}");
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"{i}- {listaNamn[i]}");
}                                                                                                                               

// Skriv ut alla namn i listan med for-loop
for (int i = 0; i < listaNamn.Count; i++)
{
    Console.WriteLine($"{i}- {listaNamn[i]}");  
}
    Console.WriteLine("Nu ska du fylla i tre äventyrspel");
List<string> aventyrspel = [];
for (int i = 0; i < 3; i++)
{
    Console.Write("Ange ett äventyrspel: ");
    aventyrspel.Add(Console.ReadLine());
}
     Console.WriteLine("Nu ska du fylla i två actionspel");

for (int i = 0; i < 3; i++)
{
     Console.Write("Ange ett action-spel: ");
     actionSpel.Add(Console.ReadLine());
}
Console.WriteLine($"""
Här är de första två action-spelen i listan
- Spel 1: {actionSpel[0]}
- Spel 2: {actionSpel[1]}
"""); 
Console.WriteLine($"""
Här är de sista två äventyrs-spelen i listan
- Spel 1: {aventyrspel[1]}
- Spel 2: {aventyrspel[2]}
"""); 
Console.WriteLine("Här är alla action-spel i listan:");
foreach (var spel in actionSpel)
{
    Console.WriteLine($"- {spel}");
}
Console.WriteLine("Här är alla äventyrsspel i listan:");
foreach (var spel in aventyrspel)
{
    Console.WriteLine($"- {spel}");
}