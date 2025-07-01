using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q9
    {
        static void Main()
        {
            Console.Write("Enter a name: ");
            string input = Console.ReadLine();

            string output = ToggleCase(input);

            Console.WriteLine("Output: " + output);
        }

        static string ToggleCase(string str)
        {
            char[] result = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    result[i] = char.ToLower(str[i]);
                else if (char.IsLower(str[i]))
                    result[i] = char.ToUpper(str[i]);
                else
                    result[i] = str[i]; // for spaces and symbols
            }

            return new string(result);
        }
    }
}
