Console.WriteLine("--- Gestion des notes ---\n");


double max = 0;
double min = 0;
double nbrnotes = 5;
double total = 0;

for (int i = 1; i <= nbrnotes; i++)

{
    Console.Write($"- Merci de saisir la note {i} (sur /20) : ");
    double note = Convert.ToDouble(Console.ReadLine());
    if (note==1)
    {
        min=note; max=note;
    }
    else if (note>=max)
    {
        max = note;
    }
    else if (note>0)
    {
        min= note;
    }
    total = total + note;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"la meilleure note est {max}\n");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"la moins bonne note est {min}\n");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"la moyenne des notes est {total/nbrnotes}\n");
Console.ForegroundColor = ConsoleColor.White;

