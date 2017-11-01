using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
        }
    }
}
