List<string> lista = [];
while(true){
    Console.WriteLine("Samlingar");
    Console.WriteLine("""
    Vad vill du göra med listan?
         1.Lägg till något
         2. Ta bort något
         3. Läs upp listan
         4. Avsluta programmet
    """);
    Console.Write("(1/2/3/4): ");
    string val = Console.ReadLine();
    Console.Clear();
    if (val == "1"){
        Console.Write("Lägg till något i listan: ");
        string titel = Console.ReadLine();
        Console.Clear();
        lista.Add(titel);    
    }
    if (val == "2"){
        Console.Write("Ta bort något från listan: ");
        string titel = Console.ReadLine();
        Console.Clear();
        if (lista.Contains(titel)){
            lista.Remove(titel);
        }
    }
    if (val == "3"){
        Console.WriteLine($"Lista: {string.Join(", ", lista)}");
    }
    if (val == "4"){
        break;
    }
}