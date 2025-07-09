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
            string result = "";

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    result += char.ToLower(c);
                else
                    result += char.ToUpper(c);
            }

            Console.WriteLine("Output: " + result);
        }
    }
}
