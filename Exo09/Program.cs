Console.WriteLine("*** Calcul des intérêts ***\n");

Console.Write("Entrez le Capital de départ (en Euros) : ");
double capitalDepart = double.Parse(Console.ReadLine());

Console.Write("Entrez le taux d'intérêts (en %) : ");
double tauxInteret = double.Parse(Console.ReadLine());

Console.Write("Entrez la durée de l'épargne (en années) : ");
int epargneAnnees = int.Parse(Console.ReadLine());

double montantInteret = Math.Round(capitalDepart*Math.Pow((1+tauxInteret/100),epargneAnnees),2);

double capitalFinal = Math.Round((capitalDepart+montantInteret),2);

Console.WriteLine($"Le montant des intérêts sera de {montantInteret} après {epargneAnnees} ans");
Console.WriteLine($"Le capital final sera de {capitalFinal}");