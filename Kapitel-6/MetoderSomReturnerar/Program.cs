/* ****************************************
* *********** HEHEHEHAW *******************
**************************************** */
// Använd metoder här
//Console.Clear();
//int svar = Addera(3, 5);
//Console.WriteLine($"Svaret är {svar}");
//Console.WriteLine(Addera(3, 5));
//Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

Console.WriteLine(VändText("babian"));


/* ****************************************
************* poaisjdghgpmh ***************
**************************************** */
// Skapa metoder här
/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2) // signatur
{
    int summa = tal1 + tal2;
    return summa;
}
/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
static string VändText(string text)
{
    string omvändText = "";
    for (var i = text.Length; i >= 0 ; i--)
    {
         omvändText += text[i];
    }
    return omvändText;
}
static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
    string textSomBlirTal = Console.ReadLine();
    bool lyckades = int.TryParse(textSomBlirTal, out tal);
    if (lyckades == true)
    {
        break;
    } else {
        Console.WriteLine("Fel! Vg ang ett heltal!");8
    }
    }
    return tal;
}