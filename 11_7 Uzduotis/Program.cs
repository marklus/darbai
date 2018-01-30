
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forums23042012
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(Prod(10, 10));
            }
            static int Prod(int a, int b)
            {
                if (a != 0 && b != 0)
                {
                    int sum = 0;
                    for (int i = 0; i < b; i++)
                    {
                        sum += a;
                    }
                    return sum;
                }
                else
                {
                    return 0;
                }
            }
        }
    }

}
