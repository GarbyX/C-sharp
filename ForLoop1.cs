using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbyX
{
    class Program
    {
        static void Main(string[] args)
        {
            # for (int x = 0; x < 10; x+=3)
            # The init and increment statements may be left out but the semicolons are mandatory.
            int x = 10;
            for ( ; x > 0; x -= 3)
            {
                Console.WriteLine(x);
            }
        }
    }
}

/*
Code Outputs:
0
3
6
9
*/
