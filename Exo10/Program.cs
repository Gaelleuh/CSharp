
Console.WriteLine("*** La lettre est-elle une voyelle ***\n");

Console.Write("Entrez une lettre de l'alphabet : ");

string lettre = Console.ReadLine().ToUpper();

if (lettre == "A" || lettre == "E" || lettre == "I" || lettre == "O" || lettre == "U" || lettre == "Y")
     

    Console.WriteLine("Cette lettre est une voyelle \n");

else 
    Console.WriteLine("Cette lettre est une consonne \n");
