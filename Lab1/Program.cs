view();

static double inputDouble()
{
    Console.Write("Podaj wartość: ");
    double a = Convert.ToDouble(Console.ReadLine());
    return a;
}

static void menues_view()
{
    switch (Global_var.operacja)
    {
        case 1:
            kalkulartor(); break;
        case 2:
            tablicy(); break;
        case 3:
            mat_tabl(); break;
        case 4:
            tabl20(); break;
        case 5:
            petla(); break;
        case 6:
            menu_bubble(); break;
        case 7:
            Environment.Exit(0); break;
        default:
            Environment.Exit(0); break;
    }
}

static void view()
{
    Console.WriteLine("1. Kalkulator");
    Console.WriteLine("2. Tablicy");
    Console.WriteLine("3. Matematyka z tablicami");
    Console.WriteLine("4. Zadanie 5");
    Console.WriteLine("5. Nieskończona pętla");
    Console.WriteLine("6. Sortowanie babełkowe");
    Console.WriteLine("7. Wyjście z programy");
    Console.Write("Wybierz aplikację: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    menues_view();
}

static void kalkulartor()
{
    Console.Clear();
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Różnica");
    Console.WriteLine("3. Iloczyn");
    Console.WriteLine("4. Iloraz");
    Console.WriteLine("5. Potęga");
    Console.WriteLine("6. Pierwiastek kwadratowy");
    Console.WriteLine("7. Trygonometria");
    Console.WriteLine("8. Wyjście w menu główne");
    Console.Write("Wypierz operację: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    kalk();
}

static void kalk()
{
    while (true)
    {
        switch (Global_var.operacja)
        {
            case 1:
                double dodatek1 = inputDouble();
                double dodatek2 = inputDouble();
                suma(dodatek1, dodatek2);
                Console.ReadKey();
                kalkulartor(); break;
            case 2:
                double odjemna1 = inputDouble();
                double odjemna2 = inputDouble();
                roznica(odjemna1, odjemna2);
                Console.ReadKey();
                kalkulartor(); break;
            case 3:
                double mnozna1 = inputDouble();
                double mnozna2 = inputDouble();
                iloczyn(mnozna1, mnozna2);
                Console.ReadKey();
                kalkulartor(); break;
            case 4:
                double dzielna1 = inputDouble();
                double dzielnik2 = inputDouble();
                iloraz(dzielna1, dzielnik2);
                Console.ReadKey();
                kalkulartor(); break;
            case 5:
                double liczba_potegi = inputDouble();
                double potega_liczby = inputDouble();
                potega(liczba_potegi, potega_liczby);
                Console.ReadKey();
                kalkulartor(); break;
            case 6:
                double liczba_pierwiastka = inputDouble();
                pierwiastek_kwadr(liczba_pierwiastka);
                Console.ReadKey();
                kalkulartor(); break;
            case 7:
                double kat = inputDouble();
                trygonometria(kat);
                Console.ReadKey();
                kalkulartor(); break;
            case 8:
                Console.Clear();
                view(); break;
            default:
                Console.Clear();
                view(); break;
        }
    }
}


static void suma(double a, double b)
{
    double sum = a + b;
    Console.WriteLine($"Suma {a} + {b} = {sum}");
    //Console.WriteLine("Suma"+ a + " " + b + "=" + sum); // inny wariant wyświetlania
}

static void roznica(double a, double b)
{
    double roznica = a - b;
    Console.WriteLine($"Różnica {a} - {b} = {roznica}");
}

static void iloczyn(double a, double b)
{
    double iloczyn = a * b;
    Console.WriteLine($"Iloczyn {a} * {b} = {iloczyn}");
}

static void iloraz(double a, double b)
{
    double iloraz = a / b;
    Console.WriteLine($"Iloraz {a} / {b} = {iloraz}");
}

static void potega(double a, double b)
{
    double potega = Math.Pow(a, b);
    Console.WriteLine($"{a} do potęgi {b} = {potega}");
}

static void pierwiastek_kwadr(double a)
{
    double pierwiastek = Math.Sqrt(a);
    Console.WriteLine($"Pierwiastek kwadratowy liczby {a} = {pierwiastek}");
}

static void trygonometria(double a)
{
    double rad = a * Math.PI / 180;
    Console.WriteLine($"Sinus kąta {a} wynosi {Math.Sin(rad)}");
    Console.WriteLine($"Cosinus kąta {a} wynosi {Math.Cos(rad)}");
    Console.WriteLine($"Tangens kąta {a} wynosi {Math.Tan(rad)}");
    Console.WriteLine($"Cotangens kąta {a} wynosi {1 / Math.Tan(rad)}");
}

static void tablicy()
{
    Console.Clear();
    Console.WriteLine("1. Wypisz tablicę");
    Console.WriteLine("2. Wypisz tablicę odwrotną");
    Console.WriteLine("3. Wypisz elementy z nieparzystnymi indeksami");
    Console.WriteLine("4. Wypisz elementy z parzystnymi indeksami");
    Console.WriteLine("5. Wyjście w menu główne");
    Console.Write("Wypierz operację: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    zadanie3();
}

static void zadanie3()
{
    while (true)
    {
        double[] tab = new double[10];
        Console.WriteLine("Podaj 10 liczb");
        if (Global_var.operacja < 5)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = inputDouble();
            }
        }
        if (Global_var.operacja == 1)
        {
            wyswietl(tab);
            Console.ReadKey();
            tablicy(); // Wyświetla tablicę normalną;
        }
        else if (Global_var.operacja == 2)
        {
            wyswietlodwrot(tab);
            Console.ReadKey();
            tablicy(); // Wyświetla tablicę odwrotną; 
        }
        else if (Global_var.operacja == 3)
        {
            wyswietl_nieparz(tab);
            Console.ReadKey();
            tablicy(); // Wyświetla elementy z nieparzystnymi indeksami
        }
        else if (Global_var.operacja == 4)
        {
            wyswietl_parz(tab); // Wyświetla elementy z parzystnymi indeksami
            Console.ReadKey();
            tablicy();
        }
        else if (Global_var.operacja == 5)
        {
            Console.Clear();
            view(); break;
        }
        else
        {
            Console.Clear();
            view(); break;
        }
    }
}


static void wyswietl(double[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        Console.Write(tab[i] + " ");
    }
    /*foreach (int item in tab)
    {
        Console.Write(item + " ");  // inny sposób przejścia przez tablicę 
    }*/
    Console.WriteLine();
}

static void wyswietlodwrot(double[] tab)
{
    for (int i = tab.Length - 1; i >= 0; i--)
    {
        Console.Write(tab[i] + " ");
    }
    Console.WriteLine();
}

static void wyswietl_nieparz(double[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        if (i % 2 == 0)
        {
            continue;
        }
        else
        {
            Console.Write(tab[i] + " ");
        }
    }
    Console.WriteLine();
}

static void wyswietl_parz(double[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(tab[i] + " ");
        }
        else
        {
            continue;
        }
    }
    Console.WriteLine();
}

static void mat_tabl()
{
    Console.Clear();
    Console.WriteLine("1. Suma elementów tablicy");
    Console.WriteLine("2. Iloczyn elementów tablicy");
    Console.WriteLine("3. Średnia elementów tablicy");
    Console.WriteLine("4. Wyszukiwanie minimalnego elementu tablicy");
    Console.WriteLine("5. Wyszukiwanie największego elementu tablicy");
    Console.WriteLine("6. Wyjście w menu główne");
    Console.Write("Wypierz operację: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    zadanie4();
}

static void zadanie4()
{
    while (true)
    {
        double[] tab = new double[10];
        Console.WriteLine("Podaj 10 liczb");
        if (Global_var.operacja < 6)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = inputDouble();
            }
        }
        switch (Global_var.operacja)
        {
            case 1:
                suma_tabl(tab);
                Console.ReadKey();
                mat_tabl(); break;
            case 2:
                iloczyn_tabl(tab);
                Console.ReadKey();
                mat_tabl(); break;
            case 3:
                srednia_tabl(tab);
                Console.ReadKey();
                mat_tabl(); break;
            case 4:
                min_elem_tabl(tab);
                Console.ReadKey();
                mat_tabl(); break;
            case 5:
                maks_elem_tabl(tab);
                Console.ReadKey();
                mat_tabl(); break;
            case 6:
                Console.Clear();
                view(); break;
            default:
                Console.Clear();
                view(); break;
        }
    }
}
static void suma_tabl(double[] tab)
{
    double sum_elem = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        sum_elem += tab[i];
    }
    Console.WriteLine($"Suma elementów tablicy = {sum_elem}");
}

static void iloczyn_tabl(double[] tab)
{
    double iloczyn_elem = 1;
    for (int i = 0; i < tab.Length; i++)
    {
        iloczyn_elem *= tab[i];
    }
    Console.WriteLine($"Iloczyn elementów tablicy = {iloczyn_elem}");
}

static void srednia_tabl(double[] tab)
{
    double sum_elem = 0;
    double srednia_elem = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        sum_elem += tab[i];
    }
    srednia_elem = sum_elem / tab.Length;
    Console.WriteLine($"Średnia elementów tablicy = {srednia_elem}");
}

static void min_elem_tabl(double[] tab)
{
    double min_elem = tab[0];
    for (int i = 1; i < tab.Length; i++)
    {
        if (min_elem > tab[i])
        {
            min_elem = tab[i];
        }
    }
    Console.WriteLine($"Minimalny element = {min_elem}");
}

static void maks_elem_tabl(double[] tab)
{
    double maks_elem = tab[0];
    for (int i = 1; i < tab.Length; i++)
    {
        if (maks_elem < tab[i])
        {
            maks_elem = tab[i];
        }
    }
    Console.WriteLine($"Największy element = {maks_elem}");
}

static void tabl20()
{
    Console.Clear();
    Console.WriteLine("1. Wyświetlanie tablicy(zadanie5)");
    Console.WriteLine("2. Wyjście w menu główne");
    Console.Write("Wypierz operację: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    zadanie5();
}

static void zadanie5()
{
    while (true)
    {
        switch (Global_var.operacja)
        {
            case 1:
                zadanie_5();
                Console.ReadKey();
                tabl20(); break;
            case 2:
                Console.Clear();
                view(); break;
        }
    }
}

static void zadanie_5()
{
    for (int i = 20; i >= 0; i--)
    {
        if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
        {
            continue;
        }
        Console.Write(i + " ");
    }
}

static void petla()
{
    Console.Clear();
    Console.WriteLine("1. Neskończona pętla");
    Console.WriteLine("2. Wyjście w menu główne");
    Console.Write("Wybierz operację: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    zadanie6();
}

static void zadanie6()
{
    switch (Global_var.operacja)
    {
        case 1:
            while (true)
            {
                double liczba = inputDouble();
                if (liczba >= 0)
                {
                    continue;
                }
                else
                {
                    Console.Clear();
                    petla();
                    break;
                }
            }
            break;
        case 2:
            Console.Clear();
            view(); break;
        default:
            Console.Clear();
            view(); break;
    }
}

static void menu_bubble()
{
    Console.Clear();
    Console.WriteLine("1. Bubelkowe sortówanie");
    Console.WriteLine("2. Wyjście w menu główne");
    Console.Write("Wybierz operację: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    bubblesort_new();
}

static void bubblesort_new()
{
    while (true)
    {
        if (Global_var.operacja < 2)
        {
            Console.Write("Podaj ilość elementów tablicy: ");
            int dlugosctabl = Convert.ToInt32(Console.ReadLine());
            double[] tab_sort = new double[dlugosctabl];
            for (int i = 0; i < tab_sort.Length; i++)
            {
                tab_sort[i] = inputDouble();
            }
            bubblesort(tab_sort, dlugosctabl);
            Console.ReadKey();
            menu_bubble(); break;
        }
        else
        {
            Console.Clear();
            view(); break;
        }
    }
}

static void bubblesort(double[] tab_sort, int dlugosctabl)
{
    for (int step = 0; step < dlugosctabl - 1; step++)
    {
        for (int i = 0; i < tab_sort.Length - 1; i++)
        {
            if (tab_sort[i] > tab_sort[i + 1])
            {
                double teraz = tab_sort[i];
                tab_sort[i] = tab_sort[i + 1];
                tab_sort[i + 1] = teraz;
            }
        }
    }
    foreach (double i in tab_sort)
    {
        Console.Write(i + " ");
    }
}

public static class Global_var
{
    public static Int32 operacja;
}