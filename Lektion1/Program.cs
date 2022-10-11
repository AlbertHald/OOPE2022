using Lektion1;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            //Creating a new instance of a person and its parents
            Person p = new("Albert", "Hald", 22, 1)
            {
                Mother = new Person("Lisbeth", "Møller", 49, 2)
                {
                    Mother = new Person("Ingrid", "Møller", 85, 3),
                    Father = new Person("Aksel", "Møller", 87, 4)
                },
                Father = new Person("Peter", "Hald", 49, 5)
                {
                    Mother = new Person("Krista", "Hald", 76, 6) { Info = "Mega vinder" },
                    Father = new Person("Anton", "Hald", 78, 7)
                }
            };

            //Print the stamtræ
            PersonPrinter printer = new PersonPrinter();
            printer.PrintPerson(p);

            printer.PrintStamtrae(p);
        }
    }
}
