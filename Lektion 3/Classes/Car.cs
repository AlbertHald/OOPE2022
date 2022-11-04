using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_3;
class Car:IComparable<Car>
{
    public string Make { get; private set; }
    public string Model { get; private set; }
    public decimal Price { get; private set; }

    public Car(string make, string model, decimal price)
    {
        Make = make;
        Model = model;
        Price = price;
    }

    public int CompareTo(Car obj)
    {
        return Price.CompareTo(obj.Price);
    }
}
