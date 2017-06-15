using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen duong b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen duong c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int tempa = a;
            int tempb = b;
            int tempc = c;
            a = (a < 0) ? -a : a;
            b = (b < 0) ? -b : b;
            c = (c < 0) ? -c : c;
            Console.WriteLine("Gia Tri Tuyet Doi cua a: {0} la {1} ", tempa, a);
            Console.WriteLine("Gia Tri Tuyet Doi cua b: {0} la {1} ", tempb, b);
            Console.WriteLine("Gia Tri Tuyet Doi cua c: {0} la {1} ", tempc, c);
            Console.ReadKey();
        }
    }
}
