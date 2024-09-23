// Ett program för att redigera och spara textfiler
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
string choice = "";
while (true){
    Console.WriteLine("""
    ╔═════════════════╗
    ║Tim's Text Editor║
    ╠═════════════════╣
    ║1. Write new file║
    ║2. Read from file║
    ║3. Exit          ║
    ╚═════════════════╝
      ENTER NUMBER
    """);
      Console.Write(" : ");
    choice = Console.ReadLine();
    //Konditioner
    if (choice == "1"){
        Console.Clear();
            Console.WriteLine("""
    ╔═════════════════╗
    ║Enter text below ║
    ╠═════════════════╩════════════════════════════════════════════════════════╗
    """);
    Console.Write(" : ");
    string text = Console.ReadLine();
                            Console.WriteLine("""
    ║Enter Textfile Name  ║
    ╠═════════════════════╩════════════════════════════════════════════════════╣
    """);
      Console.Write(" : ");
    string adress = Console.ReadLine();
         File.WriteAllText(adress, text);
    } else if (choice == "2") {
        Console.Clear();
                    Console.WriteLine("""
    ╔═════════════════════════╗
    ║Enter Textfile Name      ║
    ╠═════════════════════════╩════════════════════════════════════════════════╗
    """);
      Console.Write(" : ");
        string adress = Console.ReadLine();
                      if (File.Exists(adress)){
                                       Console.WriteLine("""
    ╠══════════════════════════════════════════════════════════════════════════╣
    """);
      Console.Write(" : ");
        string textfile = File.ReadAllText(adress);
        Console.WriteLine(textfile);
        } else {
                    Console.Clear();
                                    Console.WriteLine("""
    ╔═════════════════════════╗
    ║ERROR 002                ║
    ║File does not Exist!     ║
    ╚═════════════════════════╝
    """);
        }
  
    } else if (choice == "3") {
        Console.Clear();
                            Console.WriteLine("""
    ╔═════════════════════════╗
    ║Exitting Program...      ║
    ╚═════════════════════════╝
    """);
    break;
    } else {
        Console.Clear();
                                    Console.WriteLine("""
    ╔═════════════════════════╗
    ║ERROR 001                ║
    ╚═════════════════════════╝
    """);
    }
}