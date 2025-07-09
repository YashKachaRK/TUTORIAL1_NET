using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q15
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, temp = num, digit;
            int digits = num.ToString().Length;

            while (temp > 0)
            {
                digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            if (sum == num)
                Console.WriteLine(num + " is an Armstrong number.");
            else
                Console.WriteLine(num + " is not an Armstrong number.");
        }
    }
}
