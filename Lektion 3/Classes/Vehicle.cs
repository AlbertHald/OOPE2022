using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_3;

public class Vehicle
{

    protected int registrationNumber;
    protected double maxVelocity;
    protected decimal value;

    public Vehicle(int registrationNumber, double maxVelocity, decimal value) 
    {
        this.registrationNumber = registrationNumber;
        this.maxVelocity = maxVelocity;
        this.value = value;
    }

    public int RegistrationNumber
    {
        get
        {
            return registrationNumber;
        }
    }

}
