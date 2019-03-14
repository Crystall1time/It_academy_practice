using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input letter: w,d,s,a ");
            string letter = Console.ReadLine().ToLower();
            switch (letter)
            {
                case "w":
                    Console.WriteLine("Move forward");
                    break;
                case "d":
                    Console.WriteLine("Move right");
                    break;
                case "s":
                    Console.WriteLine("Move backward");
                    break;
                case "a":
                    Console.WriteLine("Move left");
                    break;
                default:
                    Console.WriteLine("No need to move");
                    break;
            }
            Console.ReadKey();
                    }
    }
}
