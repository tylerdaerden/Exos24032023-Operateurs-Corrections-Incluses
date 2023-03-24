//1.1 (Conditionelles)
//
//Demander à l’utilisateur d’encoder 1 nombre ( int ), si la somme des deux moitiés de celui ci donne le nombre, afficher « le nombre est paire »
//sinon « le nombre est impaire ».

Console.WriteLine("Encodez un nombre entier");
int.TryParse(Console.ReadLine(), out int choixuser);

if ((choixuser / 2) * 2 == choixuser)
{
    Console.WriteLine(" Le Nombre est pair ");
}

else
{
    Console.WriteLine("le nombre n'est pas pair ");
}

Console.ReadLine();


// Correction Thierry 

Console.WriteLine("Encodez un nombre ");
if (!int.TryParse(Console.ReadLine()!, out int choixuser2))
{
    Console.WriteLine("Ce n'est pas un nombre !");
    return;
}

int moitie = choixuser2 / 2;

if (moitie + moitie == choixuser2)
    Console.WriteLine("Ce nombre est pair");
else
    Console.WriteLine("Ce nombre est impair");

Console.ReadLine();

