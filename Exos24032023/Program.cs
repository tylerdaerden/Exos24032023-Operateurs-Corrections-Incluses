#region Exos 24.03.2023

#region Exos 1 Conditionelle
//1.1 (Conditionelles)
//
//Demander à l’utilisateur d’encoder 1 nombre ( int ), si la somme des deux moitiés de celui ci donne le nombre, afficher « le nombre est paire »
//sinon « le nombre est impaire ».

//{
//    Console.WriteLine("Encodez un nombre entier");
//    int.TryParse(Console.ReadLine(), out int choixuser);

//    if ((choixuser / 2) * 2 == choixuser)
//    {
//        Console.WriteLine(" Le Nombre est pair ");
//    }

//    else
//    {
//        Console.WriteLine("le nombre n'est pas pair ");
//    }

//    Console.ReadLine();
//}


// Correction Thierry 

//{
//    Console.WriteLine("Encodez un nombre ");
//    if (!int.TryParse(Console.ReadLine()!, out int choixuser))
//    {
//        Console.WriteLine("Ce n'est pas un nombre !");
//        return;
//    }

//    int moitie = choixuser / 2;

//    if (moitie + moitie == choixuser)
//        Console.WriteLine("Ce nombre est pair");
//    else
//        Console.WriteLine("Ce nombre est impair");

//    Console.ReadLine();
//}

#endregion

#region Exos 2 Opérateurs

#region 2.1 Année Bissextile OK !

// 2.1
// Demandez à l'utilisateur d'entrer une année et retournez si cette année est bissextile ou non 

//{
//    Console.WriteLine("Entrez une année");

//    if (!int.TryParse(Console.ReadLine()!, out int choixuser) )
//    {
//        Console.WriteLine("Ce n'est pas un format valable, veuillez entrer votre année à l'aide d'un nombre ");
//        return;
//    }
//    if ((choixuser % 4 ==0 && choixuser % 100 != 0) || (choixuser % 400 == 0))
//    {
//        Console.WriteLine("L'Année est Bissextile");
//    }
//    else 
//    {
//        Console.WriteLine("L'Année n'est pas Bissextile");
//    }

//    Console.ReadLine();
//}

#endregion

#region 2.2 Calcul div , modulo , 2 entiers OK !

// 2.2
//Calcul de la division entière, du modulo et de la division de deux entiers.
//Résultat attendu pour 5 et 2 ➡ Division entière : 2, Modulo: 1, Division: 2,5.

//int x = 5;
//int y = 2;
//Console.WriteLine($"La division entière de {x} par {y} = {x / y}");
//Console.WriteLine($"Le modulo de {x} par {y} = {x % y}");
//Console.WriteLine($"La divsion de {x} par {y} = {(double)x / y}");

#endregion

#region 2.3 Check BBAN

// 2.3
//Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
//Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 9 7.
//(utilisez la méthode « Substring » de la classe « string »).

//Console.WriteLine("Entrez les 12 chiffres de votre BBAN");
//string BBANUser = Console.ReadLine()!;
//if (BBANUser.Length != 12)
//{
//    Console.WriteLine("Vous n'avez pas entré les 12 chiffres de votre BBAN , recommencez svp !");
//    return;
//}
//else
//{
//    Console.WriteLine($"votre BBAN est donc {BBANUser}");
//}

//Console.WriteLine(" Voyons si ce BBAN est OK ou KO ");

////petit ajout pour le fun à l'affichage
////Thread.Sleep(3000);
////Console.Clear();
//long DixPremiersBBAN = long.Parse(BBANUser.Substring(0, 10));
//int DeuxDerniersBBAN = int.Parse(BBANUser.Substring(10, 2));

//int ModuloDixPremiers = (int)DixPremiersBBAN % 97;
//Console.WriteLine(ModuloDixPremiers == DeuxDerniersBBAN || (ModuloDixPremiers == 0 && DeuxDerniersBBAN == 97) ? "OK" : "KO");

#endregion

#region 2.4 BBAN into IBAN

//2.4//Transformer un compte bancaire BBAN Belge (xxx xxxxxxx xx) en IBAN(BExx xxxx xxxx xxxx). Trouvez la démarche via un moteur de
//recherche.

// Premièrement récupérer un BBAN Valide comme exercice précédent 
string BBANUser;
do
{
    Console.WriteLine("Entrez les 12 chiffres de votre BBAN belge");
    BBANUser = Console.ReadLine()!;
}
while (BBANUser.Length != 12);
{
}

Console.WriteLine("Parfait nous allons contrôler si votre BBAN est valide , un instant.");
Thread.Sleep(2000);

long DixPremiersBBAN = long.Parse(BBANUser.Substring(0, 10));
int DeuxDerniersBBAN = int.Parse(BBANUser.Substring(10, 2));
int ModuloDixPremiers = (int)DixPremiersBBAN % 97;

if (ModuloDixPremiers != DeuxDerniersBBAN || (ModuloDixPremiers == 0 && DeuxDerniersBBAN != 97))
{
    Console.WriteLine("Votre Compte n'est pas Valide , fin de l'opération");
    Thread.Sleep(2000);
    Console.Clear();
    return;
}
else
{
    Console.WriteLine("Votre Compte est Valide, nous allons le convertir en IBAN Belge, un instant");
    Thread.Sleep(2000);
}

//BBAN to IBAN méthode 
//1) Créer un IBAN temporaire, composé du code du pays : BE pour la Belgique( ATTENTION !!!Convertir les lettres en chiffres, selon le principe "A" vaut "10" ... "Z" vaut "35") suivi de " 00 " 
//2) Calcul de la clé de contrôle: Avec l'Iban temporaire, calculer le modulo 97 et retrancher le reste de 98. Si le résultat comporte un seul chiffre, insérer un zéro devant.
//3) Assemblage IBAN définitif : BE + Clé de contrôle + num de compte BBAN

//On génère un code pays sur base de A= 10 et Z = 35 soit "11" et "14" pour BE ici 
string codePaysBE = "1114";

//Construction Iban temporaire composé ainsi : - Num BBAN + CodePays + 00
string tempIban = BBANUser + codePaysBE + "00";

//Calcul de la clé de contrôle
int ModuloIban = (int)(long.Parse(tempIban) % 97);
int Reste = 98 - (int)ModuloIban;

string CleControle = Reste.ToString("D2");// je passe par un To.String avec "2 Digits" soit une chaine de 2 chiffres pour la clé, comme ça un zéro sera mis si on obtient un seul chiffre (source https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings ) , c'est aussi pourquoi j'ai converti le Modulo et le reste en INT car les décimales ne supportent que les int 

//Reassamblage final 
string IBANUser = "BE" + CleControle + BBANUser;
Console.WriteLine($"Votre IBAN est {IBANUser} ");

Console.ReadLine();

#endregion

#endregion

#endregion