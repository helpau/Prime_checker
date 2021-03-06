using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport(@"x64/Debug/IsPrimeDLL.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool is_prime(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Является ли число простым?\nВведите число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(String.Format("Вы ввели число {0}", x));
            Console.WriteLine(is_prime(x));
        }
    }
}
