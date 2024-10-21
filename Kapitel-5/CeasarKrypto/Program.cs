// Ett program med kryptering med Caesar-Schiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering med Caesar-Schiffer");

// Ange nyckel
Console.Write("Ange krypteringsnyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine());

// Alfabetet
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
 
// Ange en bokstav
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine();
Console.Clear();
Console.Write("Meddelande: ");
int nyIndex = 0;
foreach (char bokstav in meddelande)
{
 // Hitta bokstavs position
 int index = alfabetet.IndexOf(bokstav);
 if (index == -1) {
     Console.Write(bokstav);
 } else {
     // Caesar-kryptering, addera en nyckel (t.ex två)
     nyIndex = index + nyckel;
     if (nyIndex >= 28){
        nyIndex = nyIndex - 29;
     }
 
     // Plocka ur bokstaven för nyIndex
     char krypteradBokstav = alfabetet[nyIndex];
     Console.Write(krypteradBokstav);
 }   
}

