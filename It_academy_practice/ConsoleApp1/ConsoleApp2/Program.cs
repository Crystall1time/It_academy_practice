using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";

            for (int number = letters.Length - 1; number >= 0; number--)
                Console.WriteLine(letters[number]);
            Console.ReadKey();
        }
    }
}
