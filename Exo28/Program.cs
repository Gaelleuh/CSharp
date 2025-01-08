
Console.WriteLine("*_* Insertion de valeurs *_*\n");

//Console.WriteLine("Insertion des valeurs du tableau : \n");

//int numero = 0;
//string espace = "";
//int[] valeurs = new int[10];


//for (numero =0; numero < valeurs.Length;numero++)
//{
   
//    Console.Write($"Saisir la valeur {numero+1} : ");
//    int val = Convert.ToInt32(Console.ReadLine());
//    valeurs[numero] = val;
    
//}

//foreach  (int i in valeurs)
//{
//    Console.WriteLine($"{espace} {i}");
//    espace += "\t"; // permet de décaler d'une tabulation à chaque itération
//}


//---------Pour faire la saisie automatique des valeurs dans le tableau---------//
Console.WriteLine("Insertion des valeurs du tableau : \n");

int numero = 0;
string espace = "";
int[] valeurs = new int[10];

Random remplissage = new Random();

for (numero = 0; numero < valeurs.Length; numero++)
{
    int val = remplissage.Next(1,101);
    valeurs[numero] = val;
}

foreach (int i in valeurs)
{
    Console.WriteLine($"{espace} {i}");
    espace += "\t"; // permet de décaler d'une tabulation à chaque itération
}