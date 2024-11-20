// FOOOR LOOOOP BOOONAAAANZZZZAAAA!!!!
string felmeddelande = "0";
Console.Clear();
int startvärde = 0;
int slutvärde = 0;
int summa = 0;
while(true){
    felmeddelande = "Inkorrekt inmatning";
    Console.Write("Ange Startvärde: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out startvärde);
    if (startvärde < 0){
        felmeddelande = "Startvärde mindre än noll";
        lyckades = false;
    }
    if (lyckades){
        break;
    }
    Console.WriteLine(felmeddelande);
}
while(true){
    felmeddelande = "Inkorrekt inmatning";
    Console.Write("Ange Slutvärde: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out slutvärde);
    if (slutvärde < startvärde){
        felmeddelande = "Slutvärde mindre än startvärde";
        lyckades = false;
    }
    if (lyckades){
        break;
    }
    Console.WriteLine(felmeddelande);
}
for (var i = startvärde; i < slutvärde + 1; i++)
{
    Console.WriteLine(i);
    summa = summa + i;
}
Console.WriteLine($"Summan av siffrorna {startvärde} till {slutvärde} är: {summa}");