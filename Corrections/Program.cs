#region Exercice 1.1
int annee = int.Parse(Console.ReadLine()!);
string text = (annee % 100 == 0 && annee % 4 == 0 && !(annee % 400 == 0)) ?
    $"{annee} n'est pas une année bisextile" : $"{annee} est une année bisextile";
Console.WriteLine(text);
Console.WriteLine(DateTime.IsLeapYear(annee));
#endregion

#region Exercice 1.2
int diviseur = 2, nombre = 5;
Console.WriteLine($"Division entière = {nombre / diviseur}");
Console.WriteLine($"Reste de la division entière = {nombre % diviseur}");
Console.WriteLine($"Division = {(double)nombre / diviseur}");
#endregion

string compte1 = "001275693375";
string compte2 = "001275693376";
string compte3 = "000000019497";

string compte = compte1;

#region Exercice 1.3
{
    string result;

    long tenFirst = long.Parse(compte.Substring(0, 10));
    int twoLast = int.Parse(compte.Substring(10, 2));

    int modulo = (int)(tenFirst % 97);

    result = (twoLast == ((modulo == 0) ? 97 : modulo)) ? "Ok" : "Ko";
    //result = (((modulo == 0) ? 97 : modulo) == twoLast) ? "Ok" : "Ko";

    Console.WriteLine(result);

}
#endregion

#region Exercice 1.4
{
    long tenFirst = long.Parse(compte.Substring(0, 10));
    int twoLast = int.Parse(compte.Substring(10, 2));
    int modulo = (int)(tenFirst % 97);

    if ((((modulo == 0) ? 97 : modulo) == twoLast))
    {
        //0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ
        string countryCode = "1114"; //BE B = 11 && E = 14
        string tempIbanAccount = compte + countryCode + "00";
        string resultIban = (98 - (int)(long.Parse(tempIbanAccount) % 97)).ToString("D2");
        Console.WriteLine($"Compte IBAN : {"BE" + resultIban + compte}");
    }
    else
    {
        Console.WriteLine("Compte BBAN invalide");
    }
}
#endregion