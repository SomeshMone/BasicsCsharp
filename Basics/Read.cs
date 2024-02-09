using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Read
    {
        public void Mymethod()
        {
            Console.WriteLine("Reading Methods");
            Console.WriteLine("Enter Your Name");
            string s=Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine("Enter Unique Character");
            int a = Console.Read();
            Console.WriteLine("UniCode of Character is " + a);
        }
    }
}
