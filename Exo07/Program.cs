
Console.WriteLine("*** Calcul de la longueur de l'hypothénuse ***\n");

Console.Write("Entrez la longueur du premier côté (en cm) : ");
double side1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

Console.Write("Entrez la longueur du deuxième côté (en cm) : ");
double side2 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

double side1_2 = Math.Round(Math.Pow(side1, 2), 2);

double side2_2 = Math.Round(Math.Pow(side2, 2), 2);

double hypo = Math.Round(Math.Sqrt(side1_2 + side2_2), 2);

Console.WriteLine("La longueur de l'hypothénuse est de "+ hypo + " cm²");
Console.Write("\n");