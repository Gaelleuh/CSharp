
Console.Write("Entrez le prix HT de l'objet (en Euros) : ");
double prixObjet = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

Console.Write("Entrez le taux de TVA (en %) : ");
double tauxTva = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

double montantTva = (prixObjet* tauxTva)/100;
double montantTTC = prixObjet + montantTva ;

Console.WriteLine("Le montant de la TVA est de " + montantTva+ " euros");
Console.WriteLine("Le prix TTC de l'objet est de " + montantTTC + " euros");