
Console.WriteLine("--- Quelle taille dois-je prendre ? ---\n");

Console.Write("Entrez votre taille en cm : ");
int taille = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez votre poids en kg : ");
int poids = Convert.ToInt32(Console.ReadLine());


//--------TAILLE 1--------------------------------------------------------------//

if       ((poids >= 43 && poids <= 47 && taille >= 145 && taille <= 169) ||
         (poids >= 48 && poids <= 53 && taille >= 145 && taille <= 166) ||
         (poids >= 54 && poids <= 59 && taille >= 145 && taille <= 163) ||
         (poids >= 60 && poids <= 65 && taille >= 145 && taille <= 160))
         {
    Console.WriteLine("Vous pesez " + poids + "kg et vous mesurez " + taille + "cm, votre taille de vêtement est donc la 1");
         }
//--------TAILLE 2---------------------------------------------------------------//
 else if ((poids >= 48 && poids <= 53 && taille >= 169 && taille <= 178) ||
         (poids >= 54 && poids <= 59 && taille >= 166 && taille <= 175) ||
         (poids >= 60 && poids <= 65 && taille >= 163 && taille <= 172) ||
         (poids >= 66 && poids <= 71 && taille >= 160 && taille <= 169))
         {
    Console.WriteLine("Vous pesez " + poids + "kg et vous mesurez " + taille + "cm, votre taille de vêtement est donc la 2");
         }
//--------TAILLE 3----------------------------------------------------------------//


else if  ((poids >= 54 && poids <= 59 && taille >= 166 && taille <= 175) ||
         (poids >= 60 && poids <= 65 && taille >= 163 && taille <= 172) ||
         (poids >= 66 && poids <= 71 && taille >= 160 && taille <= 169) ||
         (poids >= 72 && poids <= 77 && taille >= 163 && taille <= 183))
{
    Console.WriteLine("Vous pesez " + poids + "kg et vous mesurez " + taille + "cm, votre taille de vêtement est donc la 3");
}

else
{
    Console.WriteLine("Vous pesez " + poids + "kg et vous mesurez " + taille + "cm, votre taille n'existe pas, déso");
         }