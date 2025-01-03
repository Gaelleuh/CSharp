
Console.WriteLine("*** Le nombre est-il divisible par... ***\n");

Console.Write("Entrez un chiffre/nombre entier : ");
int entier = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez le chiffre/nombre diviseur : ");
int diviseur = Convert.ToInt32(Console.ReadLine());

Console.Write("\n");

if (entier % diviseur == 0)
{
    if (entier <= 9)
    
        Console.WriteLine($"Le chiffre est divisible par {diviseur}");
    
    else Console.WriteLine($"Le nombre est divisible par {diviseur}");
}

else
{
    if (entier >= 10)
    
        Console.WriteLine($"Le nombre n'est pas divisible par {diviseur}");
    
    else Console.WriteLine($"Le chiffre n'est pas divisible par {diviseur}");
}


