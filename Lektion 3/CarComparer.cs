using Lektion_3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_3;
class CarComparer : IComparer<Car>
{
    public int Compare(Car car1, Car car2)
    {
        if (car1.Make != car2.Make)
        {
            return car1.Make.CompareTo(car2.Make);
        }
        else if (car1.Model != car2.Model)
        {
            return car1.Model.CompareTo(car2.Model);
        }
        
        return car2.Price.CompareTo(car1.Price);
    }
}
