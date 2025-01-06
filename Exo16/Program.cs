Console.WriteLine("--- Quelle boisson souhaitez-vous ? ---\n");

Console.WriteLine("Liste des boissons disponibles :\n" +
    "1) Eau Plate\n" +
    "2) Eau Gazeuse\n" +
    "3) Coca-Cola\n" +
    "4) Fanta\n" +
    "5) Sprite\n" +
    "6) Orangina\n" +
    "7) 7Up\n");

Console.Write("Faites votre choix en tapant le chiffre correspondant(1 à 7)\n");
Console.Write("\n");
int choix = Convert.ToInt32(Console.ReadLine());

switch (choix)
{
    case 1:
        Console.WriteLine("Votre Eau Plate est servie !\n");
        break;
    case 2:
        Console.WriteLine("Votre Eau Gazeuse est servie !\n");
        break;
    case 3:
        Console.WriteLine("Votre Coca-Cola est servi !\n");
        break;
    case 4:
        Console.WriteLine("Votre Fanta est servi !\n");
        break;
    case 5:
        Console.WriteLine("Votre Sprite est servi !\n");
        break;
    case 6:
        Console.WriteLine("Votre Orangina est servi !\n");
        break;
    case 7:
        Console.WriteLine("Votre 7Up est servi !\n");
        break;
    default:
        Console.WriteLine("Votre choix n'est pas valide\n");
        break;
}






