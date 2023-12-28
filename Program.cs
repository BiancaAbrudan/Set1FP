using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NDivideK
{
    class Program
    {
        static void Main()
        {
            int n, k;
            Console.WriteLine("Introduceti n si k:");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (k == 0)
            {
                Console.WriteLine("Nu se poate imparti la zero!");
            }
            else if (n % k == 0)
            {
                Console.WriteLine("n se divide cu k");
            }
            else
            {
                Console.WriteLine("n nu se divide cu k");
            }
        }
    }
}

