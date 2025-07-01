using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q5
    {
        static void Main(string[] args)

        {

            int n, fact = 1;
            // GET USER INPUT
            Console.WriteLine("Enter Number : ");
            // STORE VALUE
            string str = Console.ReadLine();
            // CONVER NUNBER INTO INTEGER
            n = Convert.ToInt32(str);
            // START FOR LOOP
            for (int i = 1; i <= n; i++)

            {
                // CALCULATE FACTORIAL
                fact = fact * i;

            }
            //SHOW OUTPUT
            Console.WriteLine("Factorial : {0}", fact);



            Console.Read();

        }

    }
}

