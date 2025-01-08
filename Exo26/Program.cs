//Console.WriteLine("*_* Le Nombre Mystère *_*\n");

//Random aleatoire = new Random();
//int nbrMystere = aleatoire.Next(1, 51);
////Console.WriteLine(nbrMystere); //écrit le nombre dans le console

//int guess = 0, nbrEssais = 0;


//while (guess != nbrMystere)
//{
//    Console.Write("Veuillez saisir un nombre entre 1 et 50 : ");

//    guess = Convert.ToInt32(Console.ReadLine());

//    while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 50) // vérifie le type et si le nombre est bien entre 1 et 50
//        {
//        Console.WriteLine("Le nombre que vous avez saisi n'est pas entre 1 et 50");
//    }
//}  
//nbrEssais++;

//if (guess > nbrMystere)
//{
//    Console.WriteLine($"Vous avez saisi {guess}, Cherchez encore ! C'est moins !");
//}

//else if (guess < nbrMystere)
//{
//    Console.WriteLine($"Vous avez saisi {guess}, Cherchez encore ! C'est plus !");
//}
//    Console.WriteLine($"Bravo ! le nombre était {guess}, vous avez trouvé ! Trop Fort !");
//    Console.WriteLine($"Vous avez trouvé en {nbrEssais} coups.");

//----CORRECTION------//

Random aleatoire = new Random();
int nbMystere = aleatoire.Next(1, 51);
int choix = 0, nbCoups = 0;

while (choix != nbMystere)
{
    Console.Write("Veuillez saisir un nombre entre 1 et 50 : ");
    while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 50)
    {
        Console.WriteLine("Saisie invalide ! ");
    }
    nbCoups++;

    if (choix > nbMystere)
    {
        Console.WriteLine("Le nombre mystère est plus petit !");
    }
    else if (choix < nbMystere)
    {
        Console.WriteLine("Le nombre mystère est plus grand !");
    }
}

Console.WriteLine("Bravo !! vous avez trouvé le nombre mystère !");
Console.WriteLine($"Vous avez trouvé en {nbCoups} coups");





