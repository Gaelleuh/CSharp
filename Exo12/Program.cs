

Console.WriteLine("--- Dans quelle catégorie mon enfant est-il ... ? ---\n");

Console.Write("Entrez l'âge de votre enfant : ");
int ageUser = Convert.ToInt32(Console.ReadLine());

if (ageUser >= 3 && ageUser < 18)
{
    if (ageUser >= 3 && ageUser <= 6)
        Console.WriteLine(" *** Votre enfant est dans la catégorie \"Baby\" ***\n");
    else if (ageUser >= 7 && ageUser <= 8)
        Console.WriteLine(" *** Votre enfant est dans la catégorie \"Poussin\" ***\n");
    else if (ageUser >= 9 && ageUser <= 10)
        Console.WriteLine(" *** Votre enfant est dans la catégorie \"Pupille\" ***\n");
    else if (ageUser >= 11 && ageUser <= 12)
        Console.WriteLine(" *** Votre enfant est dans la catégorie \"Minime\" ***\n");
    else if (ageUser >= 13 && ageUser < 18)
        Console.WriteLine(" *** Votre enfant est dans la catégorie \"Cadet\" ***\n");
}
else
{
    if (ageUser >= 0 && ageUser < 3)
        Console.WriteLine(" *** Votre enfant est trop jeune ***\n");
    else
        Console.WriteLine(" *** Votre enfant est maintenant un adulte ! ***\n");
}