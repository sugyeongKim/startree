using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, n = 8;
            for (int i = 0; i < n; i++) 
            {
                for (j = n - 1; j > i; j--) 
                    Console.Write(" ");
                for (j = 0; j < i * 2 + 1; j++) 
                    Console.Write("*");

                Console.WriteLine("");
            }
        }
    }
}
