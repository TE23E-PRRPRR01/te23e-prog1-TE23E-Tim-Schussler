// Lista med slumpmässiga tal

/* ****************************************************************** 
**                            Main                                 **
******************************************************************* */

// Validera inmatningen
using System.Diagnostics;

Console.Clear();
 
// Deklarera variabler
// Skapa en tom lista för att spara slumpade tal
List<int> listaSlumptal = [];
int antal = LäsInHeltal();
int max = LäsInHeltal();
int min = LäsInHeltal();

for (var i = 0; i < antal; i++)
{
    // Slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max);
    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");
    listaSlumptal.Add(slumptal);
}

/* ****************************************************************** 
**                      Mina egna metoder                          **
******************************************************************* */

static int LäsInHeltal()
{
    int heltal = 0;
while(true){
    // Fråga användaren hur många slumptal vi ska ha
    Console.Write("Ange heltal: ");

    bool lyckades = int.TryParse(Console.ReadLine(), out heltal);

    if(lyckades)
    {
       break;
    }
    else
    {
       Console.WriteLine("Du måste skriva ett heltal");
    }
}
return heltal;
}