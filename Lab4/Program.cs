using Lab4;

Persona persona = new Persona("Matvii", "Ulytskyi", 18);
//persona.View();
Book first_book = new Book(persona, "Darkside", 1988);
Book second_book = new Book(persona, "Man", 2004);
Book third_book = new Book(persona, "Buisness", 1994);

Book[] book = new Book[3];
book[0] = first_book;
book[1] = second_book;
book[2] = third_book;

Reader first_reader = new Reader("Mark", "Losi", 34, book);
first_reader.ViewBook();