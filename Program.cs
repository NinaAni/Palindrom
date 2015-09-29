using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи фразу");
            var a = Console.ReadLine();
            a = System.Text.RegularExpressions.Regex.Replace(a, @"[\.!,\s:;?]", "");
            a = a.ToLower();
            char[] b = a.ToCharArray();
            Array.Reverse(b);
            var c = String.Concat(b);
            if (a == c)
                {
                    Console.WriteLine("Это палиндром");

                }
            else
                {
                    Console.WriteLine("Увы, это не палиндром");
                }
            Console.ReadLine();
            
        }
    }
}
