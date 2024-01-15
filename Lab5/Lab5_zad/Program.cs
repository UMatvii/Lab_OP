


SomeClass someClassObj = new SomeClass();
for (int i = 0; i <= 5; i++)
{
    try
    {
        someClassObj.CanThrowException();
    }

    catch(Exception e)
    {
        Console.WriteLine($"Wyjątek wystąpił w instrukcji: {i}, {e.Message}");
    }
}





try
{
    for (int i = 0; i < 5; i++)
    {
        RandomEx("Ember");
        RandomEx(null);
    }
}

catch (FirstException fe)
{
    Console.WriteLine($"Wystąpił pierwszy wyjątek: {fe.Message}");
}
catch (SecondException se)
{
    Console.WriteLine($"Wystąpił drugi wyjątek: {se.Message}");
}

catch (ThirdException te)
{
    Console.WriteLine($"Wystąpił pierwszy wyjątek: {te.Message}");
}
catch (FourthException fre)
{
    Console.WriteLine($"Wystąpił pierwszy wyjątek: {fre.Message}");
}

try
{
    zad1("Hello man");

    zad1(null);

}
catch (NullReferenceException e)
{
    Console.WriteLine($"Zgłoszono wyjątek: {e.Message}");
    Console.WriteLine($"Ślad stosu: {e.StackTrace}");
    throw;
}





static void zad1(string napis)
{
    try
    {
        if (napis == null)
        {
            throw new ArgumentNullException(nameof(napis), "Przekazany napis nie może być null!!");
        }
        int length = napis.Length;
        Console.WriteLine($"Długość napisu: {length}");
    }

    catch(Exception newEx)
    {
        throw new Exception("Błąd w przetwarzaniu napisu", newEx);
    }
   
}

static void RandomEx(string napis)
{
    Random random = new Random();
    int rdNum  =  random.Next(1, 4);
    int length = napis.Length;

    switch (rdNum)
    {
        case 1:
            throw new FirstException("Pierwszy wyjątek");

        case 2:
            throw new SecondException("Drugi wyjątek");

        case 3:
            throw new ThirdException("Trzeci wyjątek");

        case 4:
            throw new FourthException("Czwarty wyjątek");
    }
} 


class FirstException : ApplicationException
{
    public FirstException(string napis) : base(napis) { }
}

class SecondException : ApplicationException
{
    public SecondException(string napis) : base(napis) { }
}

class ThirdException : ApplicationException
{
    public ThirdException(string napis) : base(napis) { }
}

class FourthException : ApplicationException
{
    public FourthException(string napis) : base(napis) {  }
}

public class SomeClass
{
    public void CanThrowException()
    {
        if (new Random().Next(5) == 5)
        {
            throw new Exception();
        }
    }
}
