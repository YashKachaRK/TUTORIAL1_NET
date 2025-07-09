using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q21
    {
        static void Main()
        {
            Console.Write("Input the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input number: ");
            int num = int.Parse(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.Write("Series: ");
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + num;  // build the term like 5, 55, 555...
                Console.Write(term);
                if (i != n) Console.Write(" + ");
                sum += term;
            }

            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);
        }
    }
}
