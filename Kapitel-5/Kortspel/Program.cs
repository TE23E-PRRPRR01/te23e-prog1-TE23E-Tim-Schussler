Console.Clear();
// Listor
Console.WriteLine("Slumpa ett kort");
List<string> kortlek = ["🂡","🂢","🂣","🂤","🂥","🂦","🂧","🂨","🂩","🂪","🂫","🂬","🂭","🂮"];
// Exempel Två
List<int> årtal =[1957, 1969, 1989];
// Slumpa tal
int turns = 5;
while(turns > 0){
int index = Random.Shared.Next(0,13);
Console.WriteLine($"Slumpat index är {index}");
kortlek.RemoveAt(index);
//Plocka ut 7:e kortet
string kort = kortlek[index];
// Skriv ut 7:e kortet
Console.WriteLine($"Slumpade kort är {kort}");
turns --;
}