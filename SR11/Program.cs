using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());

            LinearFunction linearFunction = new LinearFunction(k, b);
            Console.WriteLine(linearFunction.Root());
            Console.ReadKey();
        }
    }
}
