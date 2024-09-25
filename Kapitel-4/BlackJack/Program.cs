// Typisk BlackJack
Console.Clear();
Console.Write("Enter name: ");
string name = Console.ReadLine();
int total = 0;
int wins = 0;
Console.Clear();
while (true)
{
Console.WriteLine(" ");
Console.WriteLine(" BLACK JACK THE GAME!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!w");
Console.WriteLine("              1. Play");
Console.WriteLine("              2. Exit");
Console.WriteLine($"                            Wins {wins} Total {total}");
string menu = Console.ReadLine();
if (menu =="2"){
break;
} else {
    Console.Clear();
// Kortens värde är
      //2-10 = 2-10
      // Knekt, dam, kung = 10
      // Ess = "1 / 11"

// Variabler
int kort = 0;
int summaSpelare = 0;
int summaDator = 0;
// Dela ut 2 kort till spleraen
kort = Random.Shared.Next(1, 11); // @T0D0 Knäkt, Dam & Kung
summaSpelare += kort;
kort = Random.Shared.Next(1, 11);
summaSpelare += kort;
// Dela ut 2 kort till datan
kort = Random.Shared.Next(1, 11);
summaDator += kort;
kort = Random.Shared.Next(1, 11);
summaDator += kort;
// Flera gånger (Loop)
while (true){
      // Skriv Summorna
      Console.WriteLine($"{summaSpelare}p : {name}");
      Console.WriteLine($"{summaDator}p : Computer");
      Console.WriteLine("            Pick another card? (y/n)");
      string svar = Console.ReadLine().ToLower();
      Console.Clear();
      if (svar == "n"){
       kort = Random.Shared.Next(1,11);
       summaDator += kort;
       Console.WriteLine($"Computer got {kort}!");
        if (summaSpelare > summaDator && summaSpelare < 21 ){
            Console.WriteLine($"{name} WON! (You are closest to 21)");
            wins ++;
            total ++;
        } else {
            if (summaDator < 21){
            Console.WriteLine("COMPUTER WON! (Computer is closest to 21)");
            total ++;
            } else {
            Console.WriteLine($"{name} WON! (Computer has above 21)");  
            wins ++;
            total ++;              
            }
        }
        break;
      }
      // Ta extra kort
            kort = Random.Shared.Next(1,11);
      summaSpelare += kort;
      // Skriv ut Kort
      Console.Clear();
      Console.WriteLine($"You got {kort}!");
      Console.WriteLine(" ");
      // Dator får Kort
                 kort = Random.Shared.Next(1,11);
      summaDator += kort;
      Console.WriteLine($"Computer got {kort}!");
      // Stanna när du vill
      // Vem har vunnit?
            // Har datorn fått 21 o vunnit?
      if (summaDator == 21){
        Console.WriteLine("COMPUTER WON! (Computer got 21)");
        total ++;
        break;
      }
      // Har spelaren fått 21 har han vunnit
      if (summaSpelare == 21){
        Console.WriteLine($"{name} WON! (Player got 21)");
        wins ++;
        total ++;
        break;
        
      }
     if (summaSpelare > 21)
     {
        Console.WriteLine("COMPUTER WON! (Player has above 21)");
        total ++;
        break;
        
     }
     if (summaDator > 21)
     {
        Console.WriteLine($"{name} WON! (Computer has above 21)");
        wins ++;
        total ++;
        break;
     }
}

}}