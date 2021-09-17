using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_method_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("упр 2.1");
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте,{name}");
            Console.ReadLine();

            //2.2
            Console.WriteLine("упр 2.2");
            Console.Write("Введите первое натуральное число: ");
            double perv = double.Parse(Console.ReadLine());
            Console.Write("Введите второе натуральное число:");
            double vtor = double.Parse(Console.ReadLine());
            {
                if (vtor == 0)
                    Console.WriteLine("На ноль делить нельзя");
                else Console.WriteLine(perv / vtor);
            }

            //2.1дз

            Console.WriteLine("дз2.1");
            Console.Write("Введите букву: ");
            char input = Console.ReadKey().KeyChar;
            char bukva = char.ToLower(input);
            char Sledbukva;
            if (bukva == 'z')
                Sledbukva = 'a';
            else
                Sledbukva = (char)(((int)bukva) + 1);
            Console.WriteLine();
            Console.WriteLine($"Следующая буква-{Sledbukva}");

            //2.2дз
            Console.WriteLine("дз2.2");
            Console.WriteLine("Квадратное уравнение вида ax^2+bx+c=0");
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            double diskrim = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;
            if (diskrim < 0)
            {
                Console.WriteLine($"Корней нет");
            }
            else
            {
                if (diskrim == 0)
                {
                    x1 = ((-b) / (2 * a));
                    Console.WriteLine($"Корнь {x1}");
                }
                else
                {
                    x1 = (((-b) + Math.Sqrt(diskrim)) / (2 * a));
                    x2 = (((-b) - Math.Sqrt(diskrim)) / (2 * a));
                    Console.WriteLine($"Первый корень {x1}");
                    Console.WriteLine($"Второй корень {x2}");
                }
            }





        }
    }
}
