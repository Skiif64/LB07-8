using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string res;
            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            c = int.Parse(Console.ReadLine());
            int aa = a * a;
            int bb = b * b;
            int cc = c * c;
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                res = "NONE";
            }
            else
            if (aa == bb + cc || bb == aa + cc || cc == aa + bb)
            {
                res = "RIGHT";
            }
            else
            if (aa < bb + cc && bb < aa + cc && cc < aa + bb)
            {
                res = "ACUTE";
            }
            else
            {
                res = "OBTUSE";
            }
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}