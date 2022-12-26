using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Perfect_Number
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The frist Number:");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter The last Number:");

            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Perfect number is :");

            for (int i = num; i < num1; i++)
            {
                double y = findfactor(i);
                if (i == y)
                {
                    Console.WriteLine("\t" + i);
                }
            }

        }
        public static double findfactor(int x)
        {
            double z = 0;
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    z = z + i;
                }

            }

            return z;

        }
    }
}
