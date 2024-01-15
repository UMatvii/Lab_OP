using Lab4_zadanie2;

Uczen uczen1 = new Uczen{SetFirstName = "Matvii", SetLastName = "Ulytskyi", Pesel = "97041635153", szkola = "Szkola 2" };
Uczen uczen2 = new Uczen{SetFirstName = "Karol", SetLastName = "Borodaj", Pesel = "89070515999", szkola = "Szkola 2" };
Uczen uczen3 = new Uczen{SetFirstName = "Mramor", SetLastName = "Korowaj", Pesel = "82061158377", szkola = "Szkola 2" };

Nauczyciel nauczyciel = new Nauczyciel{SetFirstName = "Aleksandr", SetLastName = "Monak", TytulNaukowy = "dr", PodwladniUczniowie = new List<Uczen>{ uczen1, uczen2, uczen3 } };



nauczyciel.CanGoHomeAlone();