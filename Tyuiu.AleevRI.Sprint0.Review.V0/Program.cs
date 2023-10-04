using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AleevRI.Sprint0.Review.V0.Lib;
    
namespace Tyuiu.AleevRI.Sprint0.Review.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"({x} + {y} + {z}) * 5 =" + DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
