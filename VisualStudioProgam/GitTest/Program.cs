using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello\n\nPlease enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Hello{0}", name);

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age <20)
            {
                Console.WriteLine("liar");
            }
            else
            {
                Console.WriteLine("[0] is really old",name);
            }
        }
    }
}
