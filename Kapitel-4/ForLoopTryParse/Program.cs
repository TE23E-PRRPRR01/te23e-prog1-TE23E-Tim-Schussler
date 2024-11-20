//Program för hantering av användarens inmatning
//    bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
while(true){
Console.Clear();
// Ange namn
Console.Write("Skriv namn: ");
string namn = Console.ReadLine();
int loopar = 0;
// Ange loopar loop
while(true){
    Console.Write("Skriv antalet loopar: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out loopar);
    if (loopar > 10 || loopar < 1){
        lyckades = false;
    }
    if (lyckades)
    {
        break; 
    }
    
    Console.WriteLine("Fel inmatning");
}
// Kör loop
for (var loop = 0; loop < loopar; loop++)
{
    Console.WriteLine($"{loop}.{namn}");
}  
// Ange ett annat tal
double tal = 0;
while(true){
    Console.Write("Ange ett tal: ");
    bool lyckades = double.TryParse(Console.ReadLine(), out tal);
    if (lyckades){
        break;
    }
    Console.WriteLine("Fel inmatning");
}
// Gör Anräkningar
Console.WriteLine($"Multiplicerat med 2: {tal * 2}");
Console.WriteLine($"Dividerat med 2: {tal / 2}");
Console.WriteLine($"Adderat med 2: {tal + 2}");
Console.WriteLine($"Subtraherat med 2: {tal - 2}");
// Avgör om programmet ska köras igen
Console.Write("Kör igen? (j/n) ");
string val = Console.ReadLine();
if (val == "n" || val == "N"){
    break;
}
}