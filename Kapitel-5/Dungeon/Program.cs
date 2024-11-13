// ETT DUNGEON-SPEL MED MASSA RUM, FIENDER, SAKER, SKATTER!!!!!!!!!!!!!!!!!!
Console.Clear();
Console.WriteLine("Ett dungeon-spel");

// Programvariabler
string rum = "hallen";
List <string> inventarie =[];
int poster = 0;
// Spelloop
while (true)
{
    // Är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("DU ÄR I HALLEN!!!");
        Console.WriteLine("1. TITA RUONT"); 
        Console.WriteLine("2. GÅ TILL DET BÄTTRE RUMMET");
        Console.Write("VAD VILLE DU GÖREN??  ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar runt i rummet och ser KIM KARDASHIAN!?");
        } else if (val == "2"){
            rum = "rum 1";
            Console.WriteLine("DU GÅR IN I NÄSTA RUM...................");
        }
    }
    else if (rum == "rum 1")
    {
        Console.WriteLine("DU ÄR I DET BÄTTRE RUmmet??");
        Console.WriteLine("1. TITA RUONT"); 
        Console.WriteLine("2. GÅ TILL EN SKUM DÖRR");
        Console.WriteLine("3. GÅ TILL HALLEN");
        Console.Write("VAD VILLE DU GÖREN??  ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            if (poster == 0){
            Console.WriteLine("Du ser en poster på the COLLEGE DROPOUT");
            Console.Write("Ska du plocka upp postern???? (j/n) ");
            string val2 = Console.ReadLine();
            if (val2 == "j"){
              Console.WriteLine("Du plockade up postern");
              poster = 1;
            }
            } else {
                Console.WriteLine("Inget är här");
            }
        } else if (val == "2"){
            rum = "rum 2";
            Console.WriteLine("DU GÅR IN I DET SKUMMA RUMMET");
        }
         else if (val == "3"){
            rum = "hallen";
            Console.WriteLine("DU GÅR TILLBAKS TILL HALLEN");
        }
    } 
    else if (rum == "rum 2")
    {
        int händelse = Random.Shared.Next(1,2);
        if (händelse == 1){
                Console.WriteLine("En vild Alvin dyker upp");
                if (poster == 1){
                Console.WriteLine("Du skrämmde bort Alvin med kraften av THE COLLEGE DROPOUT");
                } else {
                Console.WriteLine("Alvin dödade dig");
                break;
                }
        }
        Console.WriteLine("Du är i ett läskigt rum");
                Console.WriteLine("1. GÅ TILLBAKS"); 
        Console.WriteLine("2. GÅ TILL NÄSTA RUM");
        Console.Write("VAD VILLE DU GÖREN??  ");
        string val = Console.ReadLine();
        if (val == "1")
        {
            rum = "rum 1";
            Console.WriteLine("DU GÅR TILLBKAS");
        } else if (val == "2"){
            rum = "rum 3";
            Console.WriteLine("DU GÅR IN I NÄSTA RUM...................");
        }
    }
    else if (rum == "rum 3"){

    }
}