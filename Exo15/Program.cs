
Console.WriteLine("--- Quel sera le montant de l'indemnité de licenciement ---\n");

Console.Write("Merci de saisir le dernier salaire mensuel (en Euros) : ");
int lastSalaire = Convert.ToInt32(Console.ReadLine());

Console.Write("Merci de saisir votre âge : ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Merci de saisir le nombre d'années d'ancienneté : \n");
int nbrAnneesAncien = Convert.ToInt32(Console.ReadLine());

int indemniT = 0;
int primeSupp = 0;
int indemTotale=0;

if (nbrAnneesAncien >= 1 && nbrAnneesAncien <= 10)
    indemniT += (lastSalaire / 2) * nbrAnneesAncien;
else
{
    indemniT += (lastSalaire / 2) * 10;
    indemniT += lastSalaire * (nbrAnneesAncien - 10);

}

if (age >= 46 && age <= 49)
    primeSupp = (lastSalaire * 2);
else if (age >= 50)
    primeSupp = (lastSalaire * 5);

indemTotale = indemniT + primeSupp;

Console.WriteLine($"Votre indemnité sera de : {indemTotale} euros");
