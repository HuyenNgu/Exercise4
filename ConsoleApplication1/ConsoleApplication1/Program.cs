using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello");
        }
        public static bool IsOdd(int n)
        {
            bool test = true;
            if (n%2==0)
            {
                test = false;
            }
            return test;
        }
        public static bool isEven(int n1)
        {
            bool test1 = true;
            if (n1%2!=0);
            {
                test1 = false;
            }
            return test1;
        }
        public static bool isPrime(int n2)
        {
            int dem = 0;
            bool test2 = true;
            if (n2 < 2)
            {
                test2 = false;
            }else
            {
                for (int i = 1; i <= n2; i++)
                    if (n2 % i == 0){
                        dem++;
                    }        
            }
            if (dem == 2)
            {
                test2 = true;
            }
            return test2;
        }
        public static int Square(int n4)
        {
            n4 = n4 ^ 2;
            return n4;
        }

        public static int Cube(int n5)
        {
            n5 = n5 ^ 3;
            return n5;
        }
    }
}
