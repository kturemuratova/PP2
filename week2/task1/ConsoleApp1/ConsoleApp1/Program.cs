using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Palindrom(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)

                if (s[i] != s[s.Length - i - 1])
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"D:\txt\1.txt");

            if (Palindrom(s))
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadLine();

        }
    }
}
