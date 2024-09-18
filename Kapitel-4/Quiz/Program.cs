using System.Collections.Concurrent;

int points = 0;
Console.Clear();
Console.WriteLine("Quizzing the land of the Magyars!");
Console.WriteLine("         Question 1.");
Console.WriteLine("What is the capital of Hungary?");
Console.WriteLine("A.Wrocław B.Bucharest C.Budapest");
string answer = Console.ReadLine();
if (answer == "c"){
    points++;
    Console.WriteLine("Correct!");
}else{
    Console.WriteLine("WRONG!!!");
}
Console.WriteLine();
Console.WriteLine("         Question 2.");
Console.WriteLine("   How do you skål in Hungary?");
Console.WriteLine("A.Egy! B.Egészségedre! C.Sárospatak!");
answer = Console.ReadLine();
if (answer == "b"){
    points++;
    Console.WriteLine("CORRECT!");
}else{
    Console.WriteLine("WRONG!!!");
}
Console.WriteLine();
Console.WriteLine("                Question 3.");
Console.WriteLine("To what nation does Transylvania belong to?");
Console.WriteLine("A.Magyarország B.Romania C.Serbia D.Unsure");
answer = Console.ReadLine();
if (answer == "a"){
    points++;
    Console.WriteLine("CORRECT!");
}else{
    Console.WriteLine("WRONG!!!");
}
Console.WriteLine();
Console.WriteLine("                     Question 4.");
Console.WriteLine("What was the first city in mainland europe to get a metro?");
Console.WriteLine("         A.Berlin B.Budapest C.London D.Paris");
answer = Console.ReadLine();
if (answer == "b"){
    points++;
    Console.WriteLine("CORRECT!");
}else{
    Console.WriteLine("WRONG!!!");
}
Console.WriteLine();
Console.WriteLine("                Question 5.");
Console.WriteLine("What is not typically a topping on Lángos?");
Console.WriteLine(" A.Sour Cream B.Grated Cheese C.Eggs D.Ham");
answer = Console.ReadLine();
if (answer == "c"){
    points++;
    Console.WriteLine("CORRECT!");
}else{
    Console.WriteLine("WRONG!!!");
}
Console.WriteLine();
Console.WriteLine("                Question 6.");
Console.WriteLine("What is the biggest lake in Hungary?");
Console.WriteLine(" A.Harkai-tó B.Tisza-tó C.Feher-tó D.Balaton");
answer = Console.ReadLine();
if (answer == "d"){
    points++;
    Console.WriteLine("CORRECT!");
}else{
    Console.WriteLine("WRONG!!!");
}
Console.WriteLine();
Console.WriteLine("                    Question 7.");
Console.WriteLine("      Which country doesn't border Hungary?");
Console.WriteLine("A.Slovakia B.Poland C.Ukraine D.Croatia E.Serbia");
answer = Console.ReadLine();
if (answer == "b"){
    points++;
    Console.WriteLine("CORRECT!");
}else{
    Console.WriteLine("WRONG!!!");
}
Console.WriteLine("    Congratulations! (maybe)");
Console.WriteLine("You scored " + points + "/7 points!");