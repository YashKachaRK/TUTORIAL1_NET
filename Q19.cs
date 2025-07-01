using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q19
    {
        public static void Main(string[] args)
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }

        }
    }
}
