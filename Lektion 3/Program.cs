// See https://aka.ms/new-console-template for more information
using Lektion_3;

namespace Lektion_3;

class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>()
        {
            new Car("Skoda", "Fabia", 5000m),
            new Car("Skoda", "Octavia", 60000m),
            new Car("Fiat", "500", 12345m),
            new Car("Ford", "Mustang", 9000000m),
            new Car("Ford", "Mustang", 9000001m),
            new Car("Ford", "Mustang", 200m)
        };

        cars.Sort(new CarComparer());
        
        Console.WriteLine("Sorted by price");
        foreach (Car car in cars)
        {
            Console.WriteLine($" {car.Make} {car.Model} {car.Price}");
        }
    }
}
