
Console.WriteLine("--- Accroissement de la population ---\n");

double nbrAnnees = 0;
double a2015 = 96809;
double a2xxx = 120000;
double taux = 0.0089;
double anneeDepart = 2015;

while (a2015 <= a2xxx)
{
    a2015 = (a2015 * (1 + taux));
    nbrAnnees = nbrAnnees + 1;
}
double addition = anneeDepart + nbrAnnees;

Console.WriteLine(@$"il faudra {nbrAnnees} ans pour que la ville de Tourcoing atteigne 120000 habitants.
Nous serons donc en {addition}.
Il y aura {Math.Round(a2015,0)} habitants en {addition}.");