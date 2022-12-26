using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The First Number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter The Last Number:");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("The Prime Number Is:");
            for (int i = num; i <= num1; i++)
            {
                bool x = true;
                if (i == 1)
                {
                    x = false;

                }
                else
                {
                    for (int y = 2; y < i; y++)
                    {
                        if (i % y == 0)
                        {
                            x = false;
                            break;
                        }
                    }
                    if (x)
                    {
                        Console.Write("\t" + i);
                    }
                    
                }

            }
        }
    }
}
