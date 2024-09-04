//Detta är för fritiden, inte på lektionstid
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Net;
using System.Net.WebSockets;
using System.Timers;

Console.Clear();
Console.WriteLine("Made by Tim Schüssler");
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
Console.Write("GAME STARTING IN 3...");
System.Threading.Thread.Sleep(1000);
Console.Write("2...");
System.Threading.Thread.Sleep(1000);
Console.Write("1...");
System.Threading.Thread.Sleep(1000);
string key = "None";
string flashlight = "None";
goto start;
start:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░(ü)░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░▐█▌░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░║░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You find yourself in a odd room        ║");
Console.WriteLine("║ [A. Go left] [B. Go up] [C. Go right] ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
string choice = Console.ReadLine();
if (choice == "c"){
    if (key == "yes"){
        if (flashlight == "yes"){
            goto eastDARK3;
        }else{goto eastDARK;}
   }else{
    goto startLOCK;
   }
}
if (choice == "a"){
    goto west;
}
if (choice == "b"){
    goto northstart;
}
goto start;
gameover:
Console.Clear();
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("    GAMEOVER");
Console.WriteLine(" Enter A to retry");
Console.WriteLine("");
choice = Console.ReadLine();
if (choice == "a"){
    goto start;
}
goto gameover;
startLOCK:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█████▒▒▒▒▒▒█████████████████████████████");
Console.WriteLine("█░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░(ü]▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█▀▒█");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║░▒█");
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
Console.WriteLine("█░░░░░░░░░░░░░░░░░▒▒▒▒▒██▒▒▒▒▒░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░(ü)░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░▐█▌░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You find yourself in yet another room  ║");
Console.WriteLine("║ [A. Go back] [B. Search]              ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto start;
}
if (choice == "b"){
    if (key == "None"){
    goto northkey;
   }else{
    goto northstart;
   }
}
goto northstart;
northkey:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("███░░░░█░░░░█░░░░███████████████████████");
Console.WriteLine("███░░░░█░░░░█░░░░███████████████████████");
Console.WriteLine("██████████████████▒( )▒██▒▒▒▒▒██████████");
Console.WriteLine("█░░░░░░░░░░░░░░░░░▒▀█▀░▀▀░░░░▒░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░▒▒║▒▒▒▒▒▒▒▒▒░░░░░░░░░█");
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
eastDARK:
Console.Clear();
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("▒");
Console.WriteLine("▒");
Console.WriteLine("▒(ü)");
Console.WriteLine("▒▐█▌");
Console.WriteLine("▒ ║");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You cannot see a thing...              ║");
Console.WriteLine("║[A. Go back] [B. Stumble into the dark]║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto start;
}
if (choice == "b"){
    goto eastDARK2;
}
goto eastDARK;
eastDARK2:
Console.Clear();
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("▒");
Console.WriteLine("▒");
Console.WriteLine("▒");
Console.WriteLine("▒        (ü)");
Console.WriteLine("▒        ▐█▌");
Console.WriteLine("          ║");
Console.WriteLine("");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You stumble into the dark              ║");
Console.WriteLine("║[A. Go back] [B. Stumble into the dark]║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto start;
}
if (choice == "b"){
    goto eastDARK2;
}
goto eastDARK2;
west:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("███░░░░█░░░░█░░░░██████▒▒▒▒░▒▒▒▒████████");
Console.WriteLine("███░░░░█░░░░█░░░░██████▒▒▒█░█▒▒▒████████");
Console.WriteLine("███████████████████████▒▒▒▒░▒▒▒▒████████");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒░▒▒▒▒░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░(ü)▒█");
Console.WriteLine("█▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▐█▌▒█");
Console.WriteLine("█▒▒▒▒█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║░▒█");
Console.WriteLine("█▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║It's a furnished room                  ║");
Console.WriteLine("║[A.Go back] [B.Search] [C.Hide]        ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto start;
}
if (choice == "b"){
    if (flashlight == "None"){
        goto westflash;
    }else{
        goto west;
    }
}
if (choice == "c"){
    goto hide;
}
goto west;
westflash:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("███░░░░█░░░░█░░░░██████▒▒▒▒░▒▒▒▒████████");
Console.WriteLine("███░░░░█░░░░█░░░░██████▒▒▒█░█▒▒▒████████");
Console.WriteLine("███████████████████████▒▒▒▒░▒▒▒▒████████");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒░▒▒▒▒░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒▒▒▒░▒░(ü)░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒▒▒▒░▒█▀█▌░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒▒▒▒▒▒░░║░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒█");
Console.WriteLine("█▒░░▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║Found flashlight!                      ║");
Console.WriteLine("║                                       ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
flashlight = "yes";
System.Threading.Thread.Sleep(3000);
goto west;
hide:
Console.Clear();
Console.WriteLine("                    █");
Console.WriteLine("                    █");
Console.WriteLine("                    █");
Console.WriteLine("                    █");
Console.WriteLine("                    █");
Console.WriteLine("                    ░");
Console.WriteLine("                    ░");
Console.WriteLine("                    ░");
Console.WriteLine("                    ░");
Console.WriteLine("                    ░");
Console.WriteLine("                    ░");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║                                       ║");
Console.WriteLine("║             [A.Go back]               ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto west;
}
goto hide;
east:
Console.Clear();
Console.WriteLine("                              ██████████");
Console.WriteLine("                              ██▒▒▒▒▒▒██");
Console.WriteLine("                              ██▒▒▒▒▒▒██");
Console.WriteLine("                              ██▒▒▒▒▒▒██");
Console.WriteLine("█                             ░░▒▒▒▒▒▒░");
Console.WriteLine("█▒                         ░░░░░░░░░░░░");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("█▒░░░░(ü)░░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("█▒░░░░▐█▀◄░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("█▒░░░░░║░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║With the flashlight on u can see a door║");
Console.WriteLine("║ [A. Go left] [B. Go up] [C.Search]    ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto start;
}
if (choice == "b"){
goto northeast;
   }
   if (choice == "c"){
goto eastSearch;
   }
goto east;
eastSearch:
Console.Clear();
Console.WriteLine("                              ██████████");
Console.WriteLine("                              ██▒▒▒▒▒▒██");
Console.WriteLine("                              ██▒▒▒▒▒▒██");
Console.WriteLine("                              ██▒▒▒▒▒▒██");
Console.WriteLine("█                             ░░▒▒▒▒▒▒░");
Console.WriteLine("█▒                         ░░░░░░░░░░░░");
Console.WriteLine("█▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("█▒░░░░(ü)░░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("█▒░░░░▐█▀◄░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("█▒░░░░░║░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You found a whole lot of nothing!      ║");
Console.WriteLine("║                                       ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
System.Threading.Thread.Sleep(3000);
goto east;
eastDARK3:
Console.Clear();
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("▒");
Console.WriteLine("▒");
Console.WriteLine("▒(ü)");
Console.WriteLine("▒▐█▌");
Console.WriteLine("▒ ║");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You cannot see a thing...              ║");
Console.WriteLine("║[A. Go back] [B. Activate Flashlight]  ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto start;
}
if (choice == "b"){
    goto east;
}
goto eastDARK3;
northeast:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░████████████░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░█████(ü)████░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░█████▐█▌████░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░      ║     ░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║It's a trap!                           ║");
Console.WriteLine("║Type AvOiD tRaP or DIE                 ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
System.Threading.Thread.Sleep(1000);
if (choice == "AvOiD tRaP"){
    goto northeast2;
}else{
goto falling;
}
goto falling;
northeast2:
Console.Clear();
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("████████████████████████████████████████");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░████████████░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░████████████░░░░░░░(ü)░░░░░░░░░░░░█");
Console.WriteLine("█░░░░████████████░░░░░░░▐█▌░░░░░░░░░░░░█");
Console.WriteLine("█░░░░            ░░░░░░░░║░░░░░░░░░░░░░█");
Console.WriteLine("█░░░░░░▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░█");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You are in a room with a pit           ║");
Console.WriteLine("║[a.Go back][b.Climb down]              ║                                     [c.Secret 3rd option]");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto eastDARK3;
}
if (choice == "b"){
    goto pitbottom;
}
if (choice == "c"){
    goto falling;
}
goto northeast2;
falling:
for (int fall = 1; fall < 20 ;fall ++){
    Console.Clear();
    Console.WriteLine("██████████████");
    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
    Console.WriteLine("░░░░░░░░░░░░░░");
    Console.WriteLine("´´´´´´´´´´´´´´");
for (int falline = 0;falline < fall; falline ++){
    Console.WriteLine("");
}    
Console.WriteLine(@"
    _
     \   __/
 (:c)---<___
      \__
");
System.Threading.Thread.Sleep(160);
}
goto gameover;
pitbottom:
Console.Clear();
Console.WriteLine("");
Console.WriteLine("             ,,,,,,,,,,,,,");
Console.WriteLine("             #############");
Console.WriteLine("             ░░░░░░░░░░░░░");
Console.WriteLine("             ▒▒▒▒▒▒▒▒▒▒▒▒▒");
Console.WriteLine("             ▒▒▒░░░░░░░▒▒▒");
Console.WriteLine("             ███░░░░░░░███");
Console.WriteLine("             ███░░(ü)░░███");
Console.WriteLine("             ░░░░░▐█▌░░░░░");
Console.WriteLine("             ░░░░░░║░░░░░░");
Console.WriteLine("             ░░░░░░░░░░░░░");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You are at the bottom of the pit       ║");
Console.WriteLine("║You cannot go up the way you came down ║");
Console.WriteLine("║Better hope you didn't miss anything...║");
Console.WriteLine("║[a.Go ahead][b.Search]                 ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto LFStart;
}
if (choice == "b"){
    goto pitmold;
}
goto pitbottom;
pitmold:
Console.Clear();
Console.WriteLine("");
Console.WriteLine("             ,,,,,,,,,,,,,");
Console.WriteLine("             #############");
Console.WriteLine("             ░░░░░░░░░░░░░");
Console.WriteLine("             ▒▒▒▒▒▒▒▒▒▒▒▒▒");
Console.WriteLine("             ▒▒▒░░░░░░░▒▒▒");
Console.WriteLine("             ███░░░░░░░███");
Console.WriteLine("             ███░░(Ö)░░███");
Console.WriteLine("             ░░░░░▐█▌░░░░░");
Console.WriteLine("             ░░░░░░║░░░░░░");
Console.WriteLine("             ░░░░░░░░░░░░░");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║You found mold!                        ║");
Console.WriteLine("║                                       ║");
Console.WriteLine("╚═══════════════════════════════════════╝");
System.Threading.Thread.Sleep(3000);
goto pitbottom;
LFStart:
Console.Clear();
Console.WriteLine("░░░░░░░ ░░░░░░░░░ ░░░░░░░░ ░░░░░░░ ░░░░░");
Console.WriteLine("░░░░░░░ ░░░░░░░░░ ░░░░░░░░ ░░░░░░░ ░░░░░");
Console.WriteLine("░                                      ░");
Console.WriteLine("░░░ ░░░░░░░░░ ░░░░░░░ ░░░░░░░░░░ ░░░░░░░");
Console.WriteLine("░░░ ░░░░░░░░░ ░░░░░░░ ░░░░░░░░░░ ░░░░░░░");
Console.WriteLine("░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░");
Console.WriteLine("░ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░");
Console.WriteLine("░ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒(ü)▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░");
Console.WriteLine("░ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐█▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░");
Console.WriteLine("░ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒║▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ░");
Console.WriteLine("░▒▒▒▒▒▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░");
Console.WriteLine("╔═══════════════════════════════════════╗");
Console.WriteLine("║There's 2 doors, one leads to treasure ║");
Console.WriteLine("║The other one leads to your DOOM       ║");
Console.WriteLine("║             Choose wisely...          ║");
Console.WriteLine("║ [A.Go Left] [B. Go Down] [C. Go Right]║");
Console.WriteLine("╚═══════════════════════════════════════╝");
choice = Console.ReadLine();
if (choice == "a"){
    goto doom;
}
if (choice == "b"){
    goto treasure;
}
if (choice == "c"){
    goto doom;
}
goto LFStart;
doom:
Console.Clear();
Console.WriteLine("╔═══════════════════════════════════════╗");
System.Threading.Thread.Sleep(1000);
Console.Write(".");
System.Threading.Thread.Sleep(1000);
Console.Write(".");
System.Threading.Thread.Sleep(1000);
Console.Write(".");
System.Threading.Thread.Sleep(1000);
Console.Write(".");
Console.WriteLine(".");
System.Threading.Thread.Sleep(5000);
Console.Write("You ");
System.Threading.Thread.Sleep(250);
Console.Write("died!");
System.Threading.Thread.Sleep(1000);
goto gameover;
treasure:
Console.Clear(); 
Console.WriteLine("╔═══════════════════════════════════════╗");
System.Threading.Thread.Sleep(1000);
Console.Write(".");
System.Threading.Thread.Sleep(1000);
Console.Write(".");
System.Threading.Thread.Sleep(1000);
Console.Write(".");
System.Threading.Thread.Sleep(1000);
Console.Write(".");
System.Threading.Thread.Sleep(1000);
Console.WriteLine(".");
System.Threading.Thread.Sleep(5000);
Console.WriteLine("You stepped forward into the empty room");
System.Threading.Thread.Sleep(1000);
Console.Write("You found....");
System.Threading.Thread.Sleep(1000);
Console.WriteLine(" something.");
Console.WriteLine("╚═══════════════════════════════════════╝");
System.Threading.Thread.Sleep(1000);
Console.WriteLine("Thanks for playing!");
Console.WriteLine("Made by Tim Schüssler");
Console.WriteLine(@"
O     O
 \____/
");