Console.WriteLine("*_* Question à choix multiple *_*\n");

Console.Write(@"Quelle est l'instruction qui permet de sortir d'une boucle en C# ?
        a) quit
        b) continue
        c) break
        d) exit

");


string choix;
string choixOuiNon;

Console.Write("\n");

do
    {
    Console.Write("Entrez votre réponse : ");
    choix = Console.ReadLine().ToUpper();
    if (choix == "A" || choix == "B" || choix == "D")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Réponse Incorrecte\n");
        Console.ResetColor();
        Console.Write("Un nouvel essai ? (Oui/Non): \n");
        Console.Write("\n");

        choixOuiNon = Console.ReadLine().ToUpper();


        if (choixOuiNon == "OUI")
        {
            Console.Write("Entrez votre réponse : ");
            choix = Console.ReadLine().ToUpper();
        }

        if (choixOuiNon == "NON")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Tant pis !\n");
            Console.ResetColor();
            break;
        }

        if (choixOuiNon != "OUI" || choixOuiNon != "NON")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Merci de répondre oui ou non\n");
            Console.ResetColor();
            choixOuiNon = Console.ReadLine().ToUpper();
            Console.Write("\n");
        }

    }
    else if (choix == "C")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo ! C'est la bonne réponse !");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Réponse Incorrecte\n");
        Console.ResetColor();
        Console.Write("Un nouvel essai ? (Oui/Non): \n");
        Console.Write("\n");

        choixOuiNon = Console.ReadLine().ToUpper();


        if (choixOuiNon == "OUI")
        {
            Console.Write("Entrez votre réponse : ");
            choix = Console.ReadLine().ToUpper();
        }

        if (choixOuiNon == "NON")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Tant pis !\n");
            Console.ResetColor();
            break;
        }

        if (choixOuiNon != "OUI" || choixOuiNon != "NON")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Merci de répondre oui ou non\n");
            Console.ResetColor();
            choixOuiNon = Console.ReadLine().ToUpper();
            Console.Write("\n");
        }
    }
} while (choix != "C");









