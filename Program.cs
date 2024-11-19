using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Func(5) + Func(12) + Func(19);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        public static double Func(int x)
        {
            return Math.Sqrt((x) + x) / 2;
        }
    }
}
