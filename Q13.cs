﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL1
{
    internal class Q13
    {
        static void Main()
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < 11; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
