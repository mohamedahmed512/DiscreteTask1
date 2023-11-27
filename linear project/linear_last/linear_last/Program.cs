//gaussian elimination method
using System;
namespace linear_last
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A;
            double[] b;
            int s;
           
            Console.Write("Enter side: ");
            s = Int32.Parse(Console.ReadLine());
            A = new double[s, s];
            b = new double[s];
            for (int row = 0; row < s; row++) 
            {

                for (int col = 0; col < s; col++)
                {
                    Console.Write($"A[{row},{col}]: ");
                    A[row, col] = double.Parse(Console.ReadLine());
                }
                Console.Write($"b[{row}]: ");
                b[row] = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            display(A,b);
            Console.WriteLine("--------------------------");
            // solution
            for(int p =0; p < s; p++)
            {
                for (int row =p+1; row < s; row++)
                {
                    double m = A[row, p] / A[p, p];
                    for (int col = 0; col < s; col++)
                    {
                        A[row, col] = A[row, col] - (m * A[p, col]); // row operation
                    }
                    b[row] = b[row] - (m * b[p]);
                }
            }
            // display

            display(A,b);
            Console.WriteLine("--------------------------");

            // perform elimination
            double temp = 0; // temporary
            double u = 0; // unknown
            double[] x = new double[s];
            for(int row = s-1; row >= 0; row--)
            {
                for (int col = s-1; col >= 0; col--)
                {
                    if(row == col)
                    {
                        u = A[row, col];
                        break;
                    }
                    else
                    {
                        temp += A[row, col] * b[col];
                    }
                }
                b[row] = (b[row] - temp) / u;
                x[row] = b[row];
                temp = 0;
            }
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine($"x[{i}] = {x[i]}");
            }


        }


        static void display(double[,] M,double[] b) 
        {
            int s;
            s = Convert.ToInt32(Math.Sqrt(M.Length));
            for (int row = 0; row < s; row++)
            {
                for (int col = 0; col < s; col++)
                {
                    Console.Write($"{M[row, col]}\t");
                }
                Console.Write($"| {b[row]}");
                Console.WriteLine();
            }

            

        }
       
    }
}
