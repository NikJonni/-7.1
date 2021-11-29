using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ввод данных
            Console.WriteLine("Введите стороны треугольников: ");
            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите z1: ");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите z2: ");
            double z2 = Convert.ToDouble(Console.ReadLine());
            #endregion
            CalcSquareTr(x1, y1, z1, x2, y2, z2);
            Console.ReadKey();
        }
        static void CalcSquareTr(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double p1 = (x1 + y1 + z1) / 2;
            double square1 = p1 * (p1 - x1) * (p1 - y1) * (p1 - z1);
            double square1Sqrt = Math.Sqrt(square1);
            double p2 = (x2 + y2 + z2) / 2;
            double square2 = p2 * (p2 - x2) * (p2 - y2) * (p2 - z2);
            double square2Sqrt = Math.Sqrt(square2);
            if (square1Sqrt > square2Sqrt)
                Console.Write("Площадь первого треугольника больше и равна = {0:f2}", square1Sqrt);
            if (square1Sqrt < square2Sqrt)
                Console.Write("Площадь второго треугольника больше и равна = {0:f2}", square2Sqrt);
            if (square1Sqrt == square2Sqrt)
                Console.Write("Площади треугольников равны = {0:f2}", square2Sqrt);
        }
    }
}
