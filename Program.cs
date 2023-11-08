using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi string: ");

            string a = Console.ReadLine();

            if (a.Length < 5) Console.WriteLine(a);

            else
            {
                Console.WriteLine(a.Substring(2, a.Length - 4));
            }

            Console.ReadKey();
        }
    }
}
