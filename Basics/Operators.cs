using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Operators
    {
        public void operators()
        {
            Console.WriteLine("Perform Arithmatic Operators");

            Console.WriteLine("Enter Fist Number");

            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Addition");
            Console.Write(a + b);
            Console.WriteLine("Substraction");
            Console.WriteLine(a - b);
            Console.WriteLine("Multplication");
            Console.WriteLine(a *b);
            Console.WriteLine("Division");
            Console.WriteLine(a / b);
            Console.WriteLine("Remainder");
            Console.WriteLine(a% b);
            Console.WriteLine("Is Equal Operator Check two numbers are equal or not");
            Console.WriteLine(a == b);
            Console.WriteLine("Logical Operators");
            Console.WriteLine("And Operatior");
            Console.WriteLine((10>a)&(10>b));
            Console.WriteLine("Or Operator");
            Console.WriteLine((a>10) || (b>10));
            Console.WriteLine("Not Operator");
            Console.WriteLine(!(a == b));


        }
    }
}
