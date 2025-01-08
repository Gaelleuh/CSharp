Console.WriteLine("*_* GESTION DES CONTACTS *_*\n");

Console.Write("Merci de saisir le nombre de contacts : ");
int nbrContacts = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

string newContact;
string[] listeContacts = new string[nbrContacts];
int choice;
Console.Clear();

do
{
    Console.WriteLine(@"==== MA LISTE DE CONTACTS ====
1----Saisir des contacts
2----Afficher mes contacts
0----Quitter");

    Console.Write("Faites votre choix : ");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (choice)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("==== SAISIR LES CONTACTS ====");
            Console.ResetColor();
            for (int i = 0; i < nbrContacts; i++)
            {
                Console.Write($"Nom et prénom du contact n°{i+1} : ");
                newContact = Console.ReadLine();
                listeContacts[i] = newContact;
            }
            Console.Clear();
            break;

        case 2:

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("==== AFFICHAGE DES CONTACTS ====");
            Console.ResetColor();
            for (int i = 0; i < listeContacts.Length; i++)
            {
                Console.WriteLine($"- Contact n°{i + 1} : {listeContacts[i]} \n");
            }
            Thread.Sleep(3000);
            Console.Clear() ;
            break;
        
        default:
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Erreur de saisie, recommencer !");
                Console.ResetColor();
            }
            Console.Clear();
            break;
    }
} while (choice!=0);
Environment.Exit(0);
Console.Clear();

///---------------CORRECTION---------------//



