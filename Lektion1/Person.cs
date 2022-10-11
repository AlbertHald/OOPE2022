namespace Lektion1;

class Person {

    public Person(string firstName, string lastName, int age, int id)
    {
        FirstName = firstName;
        LastName = lastName; 
        Age = age;
        ID = id;
    }


    private string _FirstName;
    public string FirstName {
        get => _FirstName;
        set
        {
            if ((value.Length > 1) && (value.Length < 40))
            {
                _FirstName = value;
            }
            else
            {
                throw new Exception("First name not valid");
            }
        }
    }

    private string _LastName;
    public string LastName
    {
        get => _LastName;
        set
        {
            if ((value.Length > 0) && (value.Length < 40))
            {
                _LastName = value;
            }
            else
            {
                throw new Exception("Last name not valid");
            }
        }
    }

    private int _Age;
    public int Age
    {
        get => _Age;

        set
        {
            if(value >= 0)
            {
                _Age = value;
            }
            else
            {
                throw new Exception("Bing Bong age");
            }
        }
    }

    private int _ID;
    public int ID
    {
        get => _ID;
        set
        {
            if (value >= 0)
            {
                _ID = value;
            }
            else
            {
                throw new Exception("ID not valid");
            }
        }
    }
    public Person? Mother;
    public Person? Father;

    public string? Info { get; set; }
}