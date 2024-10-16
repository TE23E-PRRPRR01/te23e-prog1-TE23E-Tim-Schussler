 // Ett PROGRAMM för MORSEKOD!!!!!!!!1

Console.Clear();
Console.WriteLine("En liten morsekod app");

 // Listor
List<string> alfabetet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
                          "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", 
                          "Å", "Ä", "Ö", " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"];
/////////////////////////////////////////////////////////////////////////////////////////
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", 
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", 
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", 
            "-.--", "--..", ".--.-", ".-.-", "---.", "/",  
            ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----"];
/////////////////////////////////////////////////////////////////////////////////////////

 // Läs in en text
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine();
foreach (char bokstav in meddelande){
 
    // Uppslag i alfabetet efter index
   int index = alfabetet.IndexOf(bokstav.ToString());
 
    // Hittar morsetecken?
   if (index >= 0){
       // Ta ut morsemeddelande
      string morsemeddelande = morsekod[index];
      Console.Write(morsemeddelande);
       // Spela upp morsekoden
       // Tex D = "-.."
       // Dvs loopa igenom morsekoden
       foreach (char signal in morsemeddelande){
        if (signal == '.'){
            // 1000Hz, 200ms
           Console.Beep(1000,200);
        } else if (signal == '-'){
           Console.Beep(1000,600);
        } else if (signal == '/'){
            Thread.Sleep(600);
        }
        // Paus
        Thread.Sleep(50);
       }


   } else {
      Console.Write("?");
   }
   
}
