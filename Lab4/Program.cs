using Lab4;

Persona persona = new Persona("Matvii", "Ulytskyi", 18);
Book first_book = new Book(persona, "Darkside", 1988);
Book second_book = new Book(persona, "Man", 2004);
Book third_book = new Book(persona, "Buisness", 1994);

Book[] book = new Book[3];
book[0] = first_book;
book[1] = second_book;
book[2] = third_book;

Reader first_reader = new Reader("Mark", "Losi", 34, book);
//first_reader.ViewBook();
//first_reader.View();

Persona update_persona = new Reader("Oleg", "Bram", 46, book);
update_persona.View();

Reviewer reviewer = new Reviewer(first_reader);
Console.WriteLine("Oceny: ");
for (int i = 0; i < book.Length; i++)
{
    Console.WriteLine(reviewer.Wypisz(i));
}
