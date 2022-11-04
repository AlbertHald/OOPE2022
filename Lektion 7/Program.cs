namespace Lektion_7
{
    class Program
    {
        static void Main()
        {
            string string1 = "Hej ";
            string string2 = "med ";
            string string3 = "dig!";
            Strings stringJoin = new Strings();

            Console.WriteLine(stringJoin.JoinThree(string1, string2, string3, (str1, str2) => str1+str2));
        }
    }
}



