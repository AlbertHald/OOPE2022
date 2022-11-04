using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_3;

public class House : FixedProperty
{

    protected double area;

    public House(string location, bool inCity, double area, decimal value) : base(location, inCity, value)
    {
        this.area = area;
    }

    public double Area
    {
        get
        {
            return area;
        }
    }
}
