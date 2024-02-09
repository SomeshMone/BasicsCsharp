using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class While
    {
        public void whileloop(){

            Console.WriteLine("Finding the reverse of a number");
            int a=int.Parse(Console.ReadLine());
            int temp = 0;
            while (a != 0)
            {
                int remainder = a % 10;
                temp =temp*10+ remainder;
                a = a / 10;
            }
            Console.WriteLine(temp);

         }

    }
}
