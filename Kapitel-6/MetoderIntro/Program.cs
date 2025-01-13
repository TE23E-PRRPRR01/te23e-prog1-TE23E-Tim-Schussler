Console.Clear();
Console.WriteLine("Hej metoder!");
SägHej();

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>
 
static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}
VisaMeny();
SägHej();

static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut alla uppgifter
    4. Avsluta
    """);
}
static void WeAintGotIt()
{
Console.WriteLine("Broke Broke Broke Phi Broke, we ain't got it");
}
WeAintGotIt();
WeAintGotIt();
WeAintGotIt();
WeAintGotIt();
WeAintGotIt();
WeAintGotIt();
WeAintGotIt();
WeAintGotIt();
WeAintGotIt();
WeAintGotIt();
/* *************************************************
* WOAHHHHHHHHHHHHHHHHHHHHHHHHHH
* SUPER SUPER SNYGGT
************************************************** */
SägHejNamn("Abdullah");
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}");
}

// Skriv ut ett meddelande verikalt
string meddelande = "MÅNDAG!";
for (int i = 0; i < meddelande.Length; i++)
{
    Console.WriteLine(meddelande[i]);
}
fyrkant(4);
static void fyrkant(int sidlängd)
{
    for (int i = 0; i < sidlängd; i++)
    {
        for (int b = 0; b < sidlängd; b++)
        {
        Console.Write("*");
        }
        Console.WriteLine();
    }
}
static void fahrenheit(int c)
{
    int f = c * 9/5 + 32;
    Console.WriteLine(f);
}
fahrenheit(30);