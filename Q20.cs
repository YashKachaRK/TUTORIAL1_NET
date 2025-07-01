using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q20
    {
        public static void Main(string[] args)
        {
            int number = 1;
            int totalRows = 4;

            for (int i = 1; i <= totalRows; i++)
            {
                for (int space = 1; space <= totalRows - i; space++)
                    Console.Write(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write(number++ + " ");
                Console.WriteLine();
            }

        }
    }
}
