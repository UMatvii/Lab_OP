using CsvHelper;
using lab7;

MainMenu();













static void ShowData(string filePath)
{

}


static void MainMenu()
{
    Console.WriteLine("1. Wyświetl dane");
    Console.WriteLine("2. Dodaj osobę");
    Console.WriteLine("3. Modyfikuj osobę");
    Console.WriteLine("4. Usuń osobę");
    Console.WriteLine("5. Wyjście z programu");
    Console.WriteLine("Wybierz operację: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
}

static void Actions()
{
    switch (Global_var.operacja)
    {
        case 1:
            ShowData(); break;
    }
}


public static class Global_var
{
    public static Int32 operacja;
}