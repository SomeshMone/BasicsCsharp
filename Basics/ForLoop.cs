using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class ForLoop
    {
        public void forloop()
        {
            Console.WriteLine("Finding  nth fibonacci Number");

            Console.WriteLine("Enter nth fibonacci number you want");
            int n=int.Parse(Console.ReadLine());    

            if (n == 0)
                Console.WriteLine(0);
            if (n == 1)
                Console.WriteLine(1);

            long fibNMinus2 = 0;
            long fibNMinus1 = 1;
            long fibN = 0;

            for (int i = 2; i <= n; i++)
            {
                fibN = fibNMinus1 + fibNMinus2;
                fibNMinus2 = fibNMinus1;
                fibNMinus1 = fibN;
            }

            Console.WriteLine(fibN);
        }
    }
}
