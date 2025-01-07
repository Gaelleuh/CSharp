Console.WriteLine("--- Les tables de multiplication ---\n");

for (int chiffre = 1; chiffre <= 10; chiffre++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Table de {chiffre}\n");
    for (int multiplicateur=1; multiplicateur <= 10; multiplicateur++)
    {
        Console.WriteLine($"    {chiffre} x {multiplicateur} = {chiffre*multiplicateur}");
    }
    Console.WriteLine("\n");
}
