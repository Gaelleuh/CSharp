
Console.WriteLine("*_* Le triangle formé d'étoiles *_*\n");

//Console.Write("Saisir la hauteur du triangle(entier) : ");
//int number = Convert.ToInt32(Console.ReadLine());

//string message = "";

//for (int i = 0; i <= number; i=i+1)
//{
//    message += "*";
//    Console.WriteLine(message);
//}


//------CORRECTION----------//

Console.Write("Saisir la hauteur du triangle(entier) : ");
int hauteur = Convert.ToInt32(Console.ReadLine());

//-----------Dessiner le triangle------------//

for (int ligne= 1;ligne <= hauteur;ligne++)
{
    //-----Espaces avant les astérisques pour centrer le triangle------//
    for (int espace=1;espace<=hauteur -ligne;espace++)
    {
        Console.WriteLine(" ");
    }
    for (int etoile = 1;etoile <=2*ligne-1; etoile++)
    {
        //-----Astérisques à afficher------------//
        Console.Write("*");
    }
    //--------Nouvelle ligne pour le prochain niveau du triangle--------//
    Console.WriteLine();
}