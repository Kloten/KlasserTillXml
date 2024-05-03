namespace KlasserTillXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paxml px = new Paxml();

            //px.Koder = new Koder();

            //px.Koder.Kod = new List<Kod>();

            //Kod kod = new Kod() { Id = "42", Namn = "Steve", Info = "Steves kod"};

            //px.Koder.Kod.Add(kod);

            //Serializer<Paxml>.Save(px, "testpaxml.xml");


            //Person person = new Person();

            //Serializer<Person>.Save(person, "testperson.xml");

            //-----

            Paxml px = Serializer<Paxml>.Load("siv.xml");

            foreach (Person p in px.Personal.Person)
            {
                Console.WriteLine(p.Fornamn);
            }

            Serializer<Paxml>.Save(px, "exporteradfil3.xml");
        }
    }
}
