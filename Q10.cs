using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q10
    {
        static void Main()
        {
            Console.Write("Enter mobile number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine("Output: " + masked);
            }
            else
            {
                Console.WriteLine("Mobile number too short.");
            }
        }
    }
}
