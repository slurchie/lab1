using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1.1
            
            
            double a = 22.66;
            Console.WriteLine(a);
            Console.ReadKey();

            //#1.2
            double e = 2.7;
            Console.WriteLine(e);

            //#1.3
            Console.Write("Введите число- ");
            string number =
            Console.ReadLine();
            Console.WriteLine("Вы ввесли число " + number.ToString());

            //#1.4
            Console.Write("Введите число- ");
            number =
            Console.ReadLine();
            Console.WriteLine($"{number} - вот какое число вы ввели");

            //#1.5
            int q, b, c;
            q = 1; b = 13; c = 49;
            Console.WriteLine($"{q} {b} {c}");
            Console.ReadKey();

            //#1.6
            int qq, bb, cc;
            qq = 7; bb = 15; cc = 100;
            Console.WriteLine($"{qq}  {bb}  {cc}");

            //#1.7
            int w, r, t;
            Random rnd = new Random();
            w = rnd.Next();
            r = rnd.Next();
            t = rnd.Next();
            Console.WriteLine($"{w}  {r}  {t}");

            //#1.8
            int ww, rr, tt, uu;
            ww = rnd.Next();
            rr = rnd.Next();
            tt = rnd.Next();
            uu = rnd.Next();
            Console.WriteLine($"{ww} {rr} {tt} {uu}");

            //#1.9
            int k, l;
            k = 50; l = 10;
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.ReadKey();

            //#1.10
            int s, d, f;
            s = 5; d = 10; f = 21;
            Console.WriteLine(s);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.ReadKey();

            //#1.11
            int h, v, n, m;
            h = rnd.Next();
            v = rnd.Next();
            n = rnd.Next();
            m = rnd.Next();
            Console.WriteLine(h + "\n");
            Console.WriteLine(v + "\n");
            Console.WriteLine(n + "\n");
            Console.WriteLine(m + "\n");
            Console.ReadKey();

            //#1.12
            int hh, vv, nn;
            hh = 5; vv = 10; nn = 7;
            Console.WriteLine(hh + "\n");
            Console.WriteLine(vv + "\n");
            String dim = "см";
            Console.WriteLine($"{nn} {dim}  \n");
            Console.ReadKey();

            //#1.13
            int hhh, vvv, nnn;
            hhh = 2; vvv = 13; nnn = 17;
            String sim = "кг";
            Console.WriteLine($"{hhh} {sim} \n");
            Console.WriteLine($"{vvv} {nnn}");
            Console.ReadLine();

            //2.3
            Console.Write("Сторона квадрата: ");
            double zzz = double.Parse(Console.ReadLine());
            double p = 4 * zzz;
            Console.Write("Периметр: " + p);
            Console.ReadKey(true);













        }
    }
}
