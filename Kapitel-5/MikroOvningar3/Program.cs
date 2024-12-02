Console.Clear();
List <string> mat = ["Pizza","Pasta","Sallad"];
Console.WriteLine("Alla maträtter:");
foreach (var ratt in mat)
{
    Console.WriteLine($"- {ratt}");
}
List <int> artal = [1492,1776,1914,1945,1969];
Console.WriteLine();
Console.WriteLine($"Alla årtal: {string.Join(", ", artal)}");