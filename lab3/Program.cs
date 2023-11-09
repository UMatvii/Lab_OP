//Program główny
using ConsoleApp1;

/*int[] liczby = new int[10];
//Osoba[] arrayOsoby = new Osoba[5];
// Pierwszy sposób tworzenia
Osoba[] arrayOsoba = new Osoba[]
{
    new Osoba("Jan", "Nowak", 30, "Rzeszów"),      
    new Osoba("Janina", "Nowak", 34, "Gdańsk"),
    new Osoba("Kot", "Kowal", 56, "Warszawa"),
    new Osoba("Jana", "Lotis", 32, "Kraków"),
    new Osoba("Jot", "Kito", 65, "Rzeszów")
};

// Drugi sposób tworzenia
Osoba[] arrayOsoba1 = new Osoba[3];
arrayOsoba1[0] = new Osoba("Jan", "Nowak1", 12, "Rzeszów");
arrayOsoba1[1] = new Osoba("Jan1", "Nowak1", 12, "Rzeszów");
arrayOsoba1[2] = new Osoba("Jan2", "Nowak2", 12, "Rzeszów");

// Trzeci sposób tworzenia
Osoba[] arrayOsoba2 = new Osoba[4];
string[] firstname = { "Jan", "Janina", "Maria", "Marek" };
string[] lastname = { "Nowak", "Nowak2", "Nowak3", "Nowak4" };
string[] city = { "Rzeszów", "Rzeszów", "Rzeszów", "Rzeszów" };
int[] age = {1, 2, 3, 4};

for (int i = 0; i < arrayOsoba2.Length; i++)
{
    arrayOsoba2[i] = new Osoba(firstname[i], lastname[i], age[i], city[i]);
}
 
for (int i = 0; i < arrayOsoba.Length; i++)
{
    arrayOsoba[i].View();
}

foreach (Osoba item in arrayOsoba)
{
    item.View();
}*/
//tworzenie obiektu klasy
/*Osoba osoba = new Osoba();
Osoba osoba1 = new Osoba("Jan", "Nowak", 12, "Rzeszów");

osoba.View();
osoba1.View();*/

//Laboratorium zadanie
//Zadanie 1

/*Licz[] liczby_1 = new Licz[5];
liczby_1[0] = new Licz(4);
liczby_1[1] = new Licz(54);
liczby_1[2] = new Licz(543);
liczby_1[3] = new Licz(43);
liczby_1[4] = new Licz(2);

for (int i = 0; i < liczby_1.Length; i++)
{
    Console.WriteLine(liczby_1[i].Dodaj(1));
    Console.WriteLine(liczby_1[i].Odejmij(1));
    Console.WriteLine();
}*/

// Zadanie 2

/*Sumator tabl_liczb = new Sumator();
tabl_liczb.liczby[0] = 1;
tabl_liczb.liczby[1] = 4;
tabl_liczb.liczby[2] = 6;
tabl_liczb.liczby[3] = 5;
tabl_liczb.liczby[4] = 10;
Console.WriteLine($"Suma = {tabl_liczb.Suma_tabl(tabl_liczb.liczby)}");
Console.WriteLine($"Suma = {tabl_liczb.SumaPodziel2(tabl_liczb.liczby)}");*/

Sumator tablica = new Sumator();
double[] newTabl = tablica.Tablica(liczby_konstr: [1, 5, 3, 6, 5]);
/*Console.WriteLine($"Suma elementów = {tablica.Suma_tabl(newTabl)}");
Console.WriteLine($"Suma elementów podzielnych przez 2 = {tablica.SumaPodziel2(newTabl)}");
Console.WriteLine($"Ilość elementów w tablice = {tablica.IleElementów(newTabl)}");
tablica.Wyswietl();*/
Console.Write("Podaj mniejszy indeks: ");
int lowindex = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj większy indeks: ");
int highindex = Convert.ToInt32(Console.ReadLine());
tablica.Zakres(lowindex, highindex);
