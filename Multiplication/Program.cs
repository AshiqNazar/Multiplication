using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int limit;
            //Console.WriteLine("Enter limit");
            //limit = Convert.ToInt32(Console.ReadLine());
            //int i,j,k,num;

            //for(limit=1;limit<=3;limit++)
            //{
            //    Console.WriteLine("Enter a number");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    for (i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(num + "*" + i + "=" + num * i);
            //    }
            //}

            //  int count, n, product;
            //  Console.WriteLine("Enter the count");
            //  count=Convert.ToInt32(Console.ReadLine());

            //  n = 1;
            //  for(int i = 1; i <=10; i++)
            //  {
            //      for(int j = 1; j <=count; j++)
            //      {
            //          product = j * n;
            //          Console.Write(j+"*"+n+"="+product);
            //          Console.Write("\t");
            //      }
            //      n++;
            //      Console.WriteLine(" ");
            //  }
            int count;
            Console.WriteLine("enter a number");
            count=Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<=count; i++)
            {
                for(int k=1; k<=(count-i); k++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
