
Console.WriteLine("*** Quelle est la nature du triangle ABC ? ***\n");

Console.Write("Entrez la longueur du segment AB : ");
double AB = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la longueur du segment BC : ");
double BC = Convert.ToDouble(Console.ReadLine());

Console.Write("Entrez la longueur du segment CA : ");
double CA = Convert.ToDouble(Console.ReadLine());

if (AB == BC)
{
    if (BC == CA)
    {
        Console.WriteLine("Le triangle est équilatéral\n");
    }

    else
    {
        Console.WriteLine("Le triangle est isocèle en B\n");
        }
}

else if (AB == CA)
{
    Console.WriteLine("Le triangle est isocèle en A\n");
}

else if (BC == CA)
{
    Console.WriteLine("Le triangle est isocèle en C\n");
}

else
{
    Console.WriteLine("Le triangle n'est isocèle ni en A, ni en B, ni en C");
}