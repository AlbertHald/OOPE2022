using Lektion1;
using System.Net.Cache;

namespace Lektion1;
class PersonPrinter
{
    //Printer specifik person
    public void PrintPerson(Person person)
    {
        Console.WriteLine($"First name: {person.FirstName}   Last name: {person.LastName}   Age: {person.Age}   ID: {person.ID}");
    }
    //Printer hele personens stamtræ
    public void PrintStamtrae(Person person)
    {
        if(person == null)
        {
            return;
        }
        Console.WriteLine($"First name: {person.FirstName}   Last name: {person.LastName}   Age: {person.Age}   ID: {person.ID}  Info {person.Info}");
        PrintStamtrae(person.Father);
        PrintStamtrae(person.Mother);
    }
}
