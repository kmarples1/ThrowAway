using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quackers
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dan Gilleland";

            Console.WriteLine(name);
            Console.WriteLine(name.Quack());

            Console.ReadLine();
        }
    }

    public static class Extensions //note that this is STATIC
    {
        public static string Quack(this string self)
        {
            return self + " (quack)";
        }

        //static class with static method, but now quack will be on the string datatype
    }
}
