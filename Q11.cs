using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q11
    {
        static void Main()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter gender (M/F): ");
            char gender = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (gender == 'M')
                Console.WriteLine("Mr. " + name);
            else if (gender == 'F')
                Console.WriteLine("Ms. " + name);
            else
                Console.WriteLine("Invalid gender input.");
        }
    }
}
