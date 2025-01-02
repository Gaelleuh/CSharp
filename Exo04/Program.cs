

Console.Write("Veuillez saisir votre nom : ");

string nom = Console.ReadLine();

Console.Write("Veuillez saisir votre prenom : ");

string prenom = Console.ReadLine();

Console.Write("Veuillez saisir votre âge : ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bonjour " + prenom + " " + nom+", vous avez "+age+" ans");