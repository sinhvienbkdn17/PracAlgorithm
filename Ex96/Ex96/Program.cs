using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex96
{
    class Program
    {
        public static int SumFx(int x)
        {
            var sum = 0;
            if (x >= 5)
                sum = 2 * Convert.ToInt32(Math.Pow(x, 2)) + 5 * x + 9;
            else
                sum = -2 * Convert.ToInt32(Math.Pow(x, 2)) + 4 * x - 9;
            return sum;
        }
        static void Main(string[] args)
        {
           Console.Write("Nhap gia tri cua tham so x: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ham f(x) Co Ket Qua La: {0} ", SumFx(x));
            Console.ReadLine();
        }
    }
}
