using System.IO.Pipes;
using System.Net;
using System.Net.WebSockets;
using System.Timers;
menu:
Console.Clear();
Console.WriteLine("      THE LUMBER COMPANY");
Console.WriteLine("           ░░░░░░░░");
Console.WriteLine("          ░░░░░░░░░░");
Console.WriteLine("              ██");
Console.WriteLine("             ▄██▀▀");
Console.WriteLine("              ██");
Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("░░░░░░░░░╔══════════╗░░░░░░░░░");
Console.WriteLine("░░░░░░░░░║1.New Game║░░░░░░░░░");
Console.WriteLine("░░░░░░░░░║2.Continue║░░░░░░░░░");
Console.WriteLine("         ║3.Options ║");
Console.WriteLine("         ╚══════════╝");
string choice = Console.ReadLine();
if (choice == "1"){
    goto newgame;
}
if (choice == "2"){
    goto game;
}
goto menu;
newgame:


game: