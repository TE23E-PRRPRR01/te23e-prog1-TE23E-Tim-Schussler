// Ett program för att hantera namn
List<string> namnlista = [];
while(true)
{
    Console.Clear();
    
    Console.WriteLine("""
            Namnregister

1.Registrera namn
2.Skriv ut alla namn
3.Avsluta
""");
    Console.Write("Ange ditt val: ");
    string val = Console.ReadLine(); 
    if (val == "3"){
       break;
    }  
    else if (val == "2"){
       Console.WriteLine();
       foreach (var namnet in namnlista)
       {
          Console.Write($"{namnet}, ");
       }
       Console.ReadLine();
    }  
    else if (val == "1"){
        Console.WriteLine();
        Console.Write("Ange namn: ");
       string namn = Console.ReadLine();
       namnlista.Add(namn);
    }
}



