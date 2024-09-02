//FLOCHART
Console.Clear();
Console.WriteLine("SUPAH FLOWCHARTT");
Console.WriteLine($"""
()            ()
\______________/
""");
Console.WriteLine("Does it move? (y/n)");
string answer = Console.ReadLine();
if (answer == "y")
{
    Console.WriteLine("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y"){
        Console.WriteLine("NÄMEN VA BRA AV DIG!!!");
    }else{
        Console.WriteLine("Ajaj ta fram silvertejpen");
    }
}else{
    Console.WriteLine("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y"){
        Console.WriteLine("Du har gjort något väldigt fel...");
    }else{
        Console.WriteLine("Nemas problemas!");
    }

}