using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(num + " is Even");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even");
            }
            else
            {
                Console.WriteLine(num + " is Odd");
            }
        }
    }
}