/*int poczatek = (int)DzienTygodnia.Poniedzialek;
int koniec = (int)DzienTygodnia.Niedziela;
foreach (int item in Enum.GetValues(typeof(DzienTygodnia)))
{
    Console.WriteLine(item);
}
foreach (string item in Enum.GetNames(typeof(DzienTygodnia)))
{
    Console.WriteLine(item);
}

enum DzienTygodnia
{
    Poniedzialek = 2, Wtorek, Sroda, Czwartek, Piatek, Sobota, Niedziela 
} */

/*try
{
    SprawdzWiek(-3);
}
catch (MojaKlasaWyjątków e)
{
    Console.WriteLine($"Wyjątek: {e.Message}");
}


static void Dzielenie(int a, int b)
{
    try
    {
        int wynik = a / b;
        Console.WriteLine($"Wynik: {wynik}");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"Zgłoszono wyjątek: \n {e}");
    }
    finally
    {
        Console.WriteLine("Blok finally");
    }
}

static void SprawdzWiek(int wiek)
{
    if (wiek < 0)
    {
        throw (new MojaKlasaWyjątków("Wiek nie może być liczbą ujemną"));
    }
    else
    {
        Console.WriteLine($"Podano wiek: {wiek}");
    }
}

Dzielenie(4, 2);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Dzielenie(4, 0);

class MojaKlasaWyjątków : ApplicationException
{
    public MojaKlasaWyjątków(string text) : base(text) { }
}*/



using System.Collections;

/*int[] arrays = new int[] { 1, 2, 3, 4, 5, -43, 343, 46, 4323, -542 };
Array.Sort(arrays);
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add(123);
arrayList.Add(143);
arrayList.Add(-321);
arrayList.Add(-441);
foreach (var item in arrayList)
{
    Console.Write(item + " ");
}
arrayList.Remove(arrayList[3]);
Console.WriteLine();
foreach (var item in arrayList)
{
    Console.Write(item + " ");
}*/


/*Hashtable ht = new Hashtable();
ht.Add("w67969", "Matvii Ulytskyi");
ht.Add("w67432", "Matvii Ulytskyi");
ht.Add("w68754", "Matvii Ulytskyi");
ht.Add("w68542", "Matvii Ulytskyi");

ICollection key = ht.Keys;

ICollection value = ht.Values;
foreach (var item in key)
{
    Console.Write(item + " ");
}*/

/*SortedList sortedList = new SortedList();
sortedList.Add("001", "1");
sortedList.Add("002", "2");
sortedList.Add("003", "3");
sortedList.Add("004", "4");
sortedList.Add("005", "5");
sortedList.Add("000", "4");

ICollection key1 = sortedList.Keys;

foreach (string item in key1)
{
    Console.WriteLine(item);
}*/

/*Stack stos =  new Stack();
stos.Push(3);
stos.Push(3);
stos.Push(3);
stos.Push(3);

stos.Pop();

Queue queue = new Queue();
queue.Enqueue(1);
queue.Dequeue();*/

