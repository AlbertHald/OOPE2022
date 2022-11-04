using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_7
{
    public delegate string StringJoin(string string1, string string2);
    internal class Strings
    {
        public string JoinThree(string string1, string string2, string string3, StringJoin stringJoin)
        {
            string fullString;
            fullString = stringJoin(string1, string2);
            fullString = stringJoin(fullString, string3);

            return fullString;
        }
    }
}
