namespace Lab4
{
    internal class Student : Osoba
    {
        string nrAlbumu;
        string kierunek;

        public string NrAlbumu
        {
            get { return nrAlbumu; }
            set { }
        }

        public string Kierunek
        {
            get { return kierunek; }
            set { }
        }

        public Student(string name, int age, string nrAlbumu, string kierunek) :
            base(name, age)
        {
            this.nrAlbumu = nrAlbumu;
            this.kierunek = kierunek;
        }
    }
}
