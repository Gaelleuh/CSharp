Console.WriteLine("--- Je compte jusqu'à 10 ---\n");

Console.WriteLine("Je commence à compter...\n");

int compteur = 0;

for (int i = 0; i < 10; i++)
{
    compteur++;
    Console.WriteLine($"\t{compteur}");  // \t = tabulation
}
Console.WriteLine("\n");
Console.WriteLine("Super, je sais compter jusqu'à 10 !");