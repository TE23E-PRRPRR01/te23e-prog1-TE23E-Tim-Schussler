//Detta är för fritiden, inte på lektionstid
using System.IO.Pipes;
using System.Timers;

Console.Clear();
Console.Write("WELCOME");
System.Threading.Thread.Sleep(250);
Console.Write(" TO");
System.Threading.Thread.Sleep(250);
Console.Write(" ESCAPE");
System.Threading.Thread.Sleep(250);
Console.Write(" THE");
System.Threading.Thread.Sleep(250);
Console.WriteLine(" ROOM");
System.Threading.Thread.Sleep(1000);
Console.Write("EXPERIENCE STARTING IN 3...");
System.Threading.Thread.Sleep(1000);
Console.Write("2...");
System.Threading.Thread.Sleep(1000);
Console.Write("1...");
System.Threading.Thread.Sleep(1000);
string key = "None";
goto start;
start:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You find yourself in a odd room        ║");
Console.WriteLine("║ [A. Go up] [B. Go left] [C. Go right] ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
string choice = Console.ReadLine();
if (choice == "c"){
    if (key == "yes"){
    goto startLOCK;
   }else{
    goto startLOCK;
   }
}
if (choice == "a"){
    goto northstart;
}
startLOCK:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║That door is locked!                   ║");
Console.WriteLine("║                                       ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
System.Threading.Thread.Sleep(3000);
goto start;
northstart:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("███░░░░█░░░░█░░░░███████████████████████");
Console.WriteLine("███░░░░█░░░░█░░░░███████████████████████");
Console.WriteLine("██████████████████▒▒▒▒▒▒▒▒▒▒▒▒██████████");
Console.WriteLine("█░░░░░░░░░░░░░░░░░▒░░░░██░░░░▒░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You find yourself in yet another room  ║");
Console.WriteLine("║ [A. Go back] [B. Search]              ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
string choice2 = Console.ReadLine();
if (choice2 == "a"){
    goto start;
}
if (choice2 == "b"){
    if (key == "none"){
    goto northkey;
   }else{
    goto northstart;
   }
}
northkey:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("███░░░░█░░░░█░░░░███████████████████████");
Console.WriteLine("███░░░░█░░░░█░░░░███████████████████████");
Console.WriteLine("██████████████████▒▒▒▒▒▒▒▒▒▒▒▒██████████");
Console.WriteLine("█░░░░░░░░░░░░░░░░░▒░░░░██░░░░▒░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You found a room-key!                  ║");
Console.WriteLine("║                                       ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
key = "yes";
System.Threading.Thread.Sleep(3000);
goto northstart;