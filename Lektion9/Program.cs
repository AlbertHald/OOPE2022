using Lektion9;

namespace Program;

internal class Program
{
    static void Main()
    {
        Circle circleTest = new Circle(2,-1,-1);
        Circle circleTest2 = new Circle(2,10,10);


        if (circleTest.IsPointInCircle(-1,-1))
        {
            Console.WriteLine("It is in!");
        }
        else
        {
            Console.WriteLine("Is it even in?");
        }
        if (circleTest.IsOverlap(circleTest2))
        {
            Console.WriteLine("It is in!");
        }
        else
        {
            Console.WriteLine("Is it even in?");
        }
    }
}
