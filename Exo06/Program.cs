//--------------------------CARRÉ----------------------------------//

Console.WriteLine("*** Calcul du périmètre et de l'aire d'un carré ***\n");
Console.Write("Entrez la longueur d'un côté du carré (en cm) : ");

double sidesquare = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

Console.WriteLine("Le périmètre du carré est de: " + (sidesquare*4) + " cm");
Console.WriteLine("L'aire du carré est de : " + (sidesquare * sidesquare) + " cm²");
Console.Write("\n");
//------------------------RECTANGLE--------------------------------//

Console.WriteLine("*** Calcul du périmètre et de l'aire d'un rectangle ***\n");
Console.Write("Entrez la longueur d'un côté du rectangle (en cm) : ");

double siderect1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

Console.Write("Entrez la longueur d'un autre côté du rectangle (en cm) : ");

double siderect2 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

Console.WriteLine("Le périmètre du rectangle est de : " + ((siderect1 * 2)+(siderect2*2))+" cm");
Console.WriteLine("L'aire du rectangle est de : " + (siderect1*siderect2)+" cm²");