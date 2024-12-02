// Mikrovningartvå
Console.Clear();
Console.WriteLine("MÖ3");

// Lista med fem namn
List<string> namn = ["Abdullaj","Isaak","Aldhumad","Ali","Muhammed"];
Console.WriteLine(string.Join(", ", namn));

// Lista med fem orter
List<string> orter = ["Stockholm","Blahblah","bliblo","bläblö","bleble"];
Console.WriteLine($"Fem orter {(string.Join(", ", orter))} ligger i Sverige.");

// Lista på fem årtal
List<string> årtal = ["28","2024","1344","30f.kr","1835"];
Console.WriteLine($"Fem viktiga årtal är '{(string.Join("', '", årtal))}'.");

// Lista på drycker
List<string> drycker = ["Cola","Pepsi","Coca cola","Sprite","Fanta"];
Console.WriteLine($"Fem drycker{(string.Join(", ", drycker))}.");