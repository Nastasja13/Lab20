using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        /*
         * В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
         * -       метод получает входным параметром переменную типа double;
         * -       метод возвращает значение типа double, которое является результатом вычисления.
        Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        -       длину окружности по формуле D = 2 * π* R;
        -       площадь круга по формуле S = π* R²;
        -       объем шара. Формула V = 4/3 * π * R³.
        Методы должны быть объявлены как статические.
         */

        delegate double MyDelegate(double rad);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = Length;
            Console.Write("Ведите радиус окружности R для рассчета длины окружности: ");
            double length = myDelegate(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Длина окружности L = {String.Format("{0:f}", length)}");

            myDelegate = Area;
            Console.Write($"\nВедите радиус окружности R для рассчета площади круга: ");
            double area = myDelegate(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Площадь круга S = {String.Format("{0:f}", area)}");

            myDelegate = Volume;
            Console.Write($"\nВедите радиус окружности R для рассчета бъёма шара: ");
            double volume = myDelegate(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Объём шара V = {String.Format("{0:f}", volume)}");

            Console.ReadKey();

        }
        static double Length(double rad) => (double)(2 * Math.PI * rad);
        static double Area(double rad) => (double)(Math.PI * rad * rad);
        static double Volume(double rad) => (double)(4 / 3 * Math.PI * Math.Pow(rad, 3));
    }
}
