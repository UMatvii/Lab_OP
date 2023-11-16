namespace Lab4
{
    internal class Osoba
    {
        string name;
        int age;

        string Name
        {
            get { return name; }
            set { }
        }
        int Age
        {
            get { return age; }
            set { }
        }
        public Osoba(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
