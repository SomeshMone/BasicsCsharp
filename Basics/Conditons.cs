using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Conditons
    {
        public void conditions()
        {
            Console.WriteLine("Largest Number among 3 numbers");
            Console.WriteLine("Enter First Number");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3 rd Number");
            int c= int.Parse(Console.ReadLine());
            if(a>b & a > c)
            {
                Console.WriteLine("Largest number among given 3 numbers is  " + a);
            }
            else if (b > a & b > c)
            {
                Console.WriteLine("Largest number among given 3 numbers is " + b);
            }
            else
            {
                Console.WriteLine("Largest number among given 3 numbers is " + c);
            }


        
        }
    }
}
