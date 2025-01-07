
Console.WriteLine("--- Menus et sous-menus ---\n");

Console.WriteLine("Table des matières\n");


for (int chapitre=1; chapitre<=3;chapitre++)
{
    Console.WriteLine($"Chapitre {chapitre}");
    
    for (int partie=1; partie<=3;partie++)
    {
        Console.WriteLine($"\t\t Partie {chapitre}.{partie}");
    }
}