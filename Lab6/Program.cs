using System.IO;

Console.WriteLine("Podaj nazwę pliku: ");
string nazwaPliku = Console.ReadLine();

Console.WriteLine("Podaj numer albumu: ");
string numerAlbumu = Console.ReadLine();

Plik(nazwaPliku, numerAlbumu);

using (var sr = new StreamReader($"{nazwaPliku}.txt"))
{
    var line = sr.ReadToEnd();
    Console.WriteLine();
    Console.WriteLine(line);
}   


static void Plik(string nazwaPliku, string numerAlbumu)
{
    using (var sw = new StreamWriter($"{nazwaPliku}.txt"))
    {
        sw.WriteLine($"Nazwa pliku: {nazwaPliku}");
        sw.WriteLine($"Numer albumu: {numerAlbumu}");
    }
}

static List<string> ListaPeselow(string nazwaPliku)
{
    List<string> pesels = new List<string>();
    using (StreamReader sr = new StreamReader($"{nazwaPliku}"))
    {
        string pesel;
        while ((pesel = sr.ReadLine()) != null)
        {
            pesels.Add(pesel);
        }
    }
    return pesels;
}

List<string> pesels = ListaPeselow("pesels.txt");
/*if (pesels.Count > 0)
{
    int iloscZenskichPeselow = 
}*/

