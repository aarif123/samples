using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name: ");
            string name = Console.ReadLine();
            Console.WriteLine(GetNameWithHello(name));
            Console.ReadLine();
        }

        public static string GetNameWithHello(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Not a valid name.");

            return "Hello " + name + "!";
        }
    }
}
