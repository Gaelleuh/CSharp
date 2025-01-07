Console.WriteLine("*_* Le Sapin de Noël *_*\n");

Console.OutputEncoding = System.Text.Encoding.UTF8; //permet l'utilisation des emotes

Console.Write("Saisir la hauteur du triangle(entier) : ");
int hauteur = Convert.ToInt32(Console.ReadLine());

List<ConsoleColor> ballColors = new List<ConsoleColor>()
{   ConsoleColor.Red,
    ConsoleColor.Yellow,
    ConsoleColor.Cyan,
    ConsoleColor.Magenta 
};

Random random = new Random();

while (true)
{
    for (int ligne = 1; ligne <= hauteur; ligne++)
    {
        for (int espace = 1; espace <= hauteur - ligne; espace++)
        {
            Console.Write(" ");
        }
        if (ligne == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("😻");
            continue;
        }
        for (int etoile = 1; etoile <= 2 * ligne - 1; etoile++)
        {
            string symb;
            if (random.NextDouble() > 0.40)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                symb="*";
            }
            else
            {
                Console.ForegroundColor = ballColors[random.Next(ballColors.Count)];
                symb = "¤";
            }
            Console.Write(symb);
        }
        Console.WriteLine();
    }
    Thread.Sleep(1000);
    Console.Clear();
}