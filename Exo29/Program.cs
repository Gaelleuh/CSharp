using static System.Runtime.InteropServices.JavaScript.JSType;

int numLigne = 0;
string espace = "";
int[] alphabet = new int[26];

for (numLigne = 0; numLigne < alphabet.Length; numLigne++)
{
   
    alphabet[numLigne] = 65+numLigne;
}

for (int i=0; i<alphabet.Length;i++)
{
    Console.WriteLine($"{espace}{(char)alphabet[i]}");
    espace += " "; // permet de décaler d'une tabulation/un espace à chaque itération
}