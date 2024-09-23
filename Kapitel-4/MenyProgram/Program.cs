// Ett menyprogram
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
// Val variabel
string val = "";
// En loop
while (true)
{
    // Visar meny och läser in dina val
    Console.WriteLine("""
    ╓────────────────────╖
    ║Välj ett alternativ:║
    ╙───╥────────────────╨──────────────╖
        ║1.Omvandla text till versaler  ║
        ║2.Omvandla en text till gemener║
        ║3.Avsluta                      ║
        ╙───────────────────────────────╜
    """);
    val = Console.ReadLine();
    // Konditioner
    if (val == "1")
    {
        Console.WriteLine("""

           ╓────────────────────╖
           ║ Text till Versaler ║
           ║ Ange en mening     ║
           ╙────────────────────╜
        """);
        string texten = Console.ReadLine().ToUpper();
        Console.WriteLine($"Resultat : {texten}");
    } else if (val == "2")
    {
                Console.WriteLine("""

           ╓────────────────────╖
           ║ Text till Gemener  ║
           ║ Ange en mening     ║
           ╙────────────────────╜
        """);
        string texten = Console.ReadLine().ToUpper();
        Console.WriteLine($"Resultat : {texten}");
    } else if (val == "3")
    {
        Console.WriteLine("""

           ╓────────────────────╖
           ║ Exit               ║
           ║ Avslutar...        ║
           ╙────────────────────╜
        """);
    } else {
        Console.WriteLine("""

           ╓────────────────────╖
           ║ ERROR         024  ║
           ║ Insufficient Input ║
           ╙────────────────────╜
        """);
    }
}