
Console.WriteLine("*_* Est pair...? Est impair...? *_*\n");

int numero = 0;
Random remplissageAuto = new Random();

Console.Write("Combien de nombre contiendra le tableau ? : ");
int nbrInTab = Convert.ToInt32(Console.ReadLine());
int[] valeurs = new int[nbrInTab];

Console.WriteLine("Affectation automatique des valeurs du tableau :\n");

for (numero = 0; numero < valeurs.Length; numero++)
{
    int val = remplissageAuto.Next(1, 101);
    valeurs[numero] = val;

    if (val % 2 == 0)
    {
        Console.WriteLine($"Le nombre {val} est Pair");
    }
    else
        Console.WriteLine($"Le nombre {val} est Impair");
}
