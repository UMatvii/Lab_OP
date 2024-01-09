static void zad1(string napis)
{
    try
    {
        zad1(null);
    }
    catch (NullReferenceException e)
    {
        Console.WriteLine($"Zgłoszono wyjątek: {e.StackTrace}");
        Console.WriteLine(e.Message);
    }
}



static void przyczyna(string napis)
{
    if ( napis == null)
    {
        throw new ArgumentNullException(nameof(napis));
    }
    else
    {
        Console.WriteLine($"Podano wiek: {napis}");
    }
}

class Exception : ApplicationException
{
    public Exception(string napis) : base(napis) { }
}