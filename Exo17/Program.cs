Console.WriteLine("--- Dans quelle catégorie mon enfant est-il ... ? ---\n");

Console.Write("Entrez l'âge de votre enfant :\n");
Console.Write("\n");
int age = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
switch (age)
{
    case < 3:
        Console.WriteLine("Votre enfant est trop jeune !");
        break;
    case >= 3 and <=6:
        Console.WriteLine("Votre enfant est dans la catégorie \"Baby\" !");
        break;
    case >= 7 and <= 8:
        Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\" !");
        break;
    case >= 9 and <= 10:
        Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\" !");
        break;
    case >= 11 and <= 12:
        Console.WriteLine("Votre enfant est dans la catégorie \"Minime\" !");
        break;
    case >= 13 and <= 17:
        Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\" !");
        break;
    default:
        Console.WriteLine("Votre enfant est trop vieux !");
        break;
}
