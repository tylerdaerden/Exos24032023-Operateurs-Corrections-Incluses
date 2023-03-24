#region Exos 24.03.2023

#region Exos 1 Conditionelle
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

#endregion

#region Exos 2 Opérateurs

#region 2.1 Année Bissextile

// 2.1
// Demandez à l'utilisateur d'entrer une année et retournez si cette année est bissextile ou non 


#endregion

#region 2.2 Calcul div , modulo , 2 entiers

// 2.2
//Calcul de la division entière, du modulo et de la division de deux entiers.
//Résultat attendu pour 5 et 2 ➡ Division entière : 2, Modulo: 1, Division: 2,5.


#endregion


#region 2.3 Check BBAN

// 2.3
//Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
//Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres son t 9 7.
//(utilisez la méthode « Substring » de la classe « string »).


#endregion


#region 2.4 BBAN into IBAN

//2.4//Transformer un compte bancaire BBAN Belge (xxx xxxxxxx xx) en IBAN(BExx xxxx xxxx xxxx). Trouvez la démarche via un moteur de
//recherche.



#endregion




#endregion





#endregion