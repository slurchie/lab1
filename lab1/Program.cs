using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1.1

            Console.WriteLine("1.1");
            double a = 22.66;
            Console.WriteLine(a);
            Console.ReadKey();

            //#1.2
            Console.WriteLine("1.2");
            double e = 2.7;
            Console.WriteLine(e);

            //#1.3
            Console.WriteLine("1.3");
            Console.Write("Введите число- ");
            string number =
            Console.ReadLine();
            Console.WriteLine("Вы ввесли число " + number.ToString());

            //#1.4
            Console.WriteLine("1.4");
            Console.Write("Введите число- ");
            number =
            Console.ReadLine();
            Console.WriteLine($"{number} - вот какое число вы ввели");

            //#1.5
            Console.WriteLine("1.5");
            int q, b, c;
            q = 1; b = 13; c = 49;
            Console.WriteLine($"{q} {b} {c}");
            Console.ReadKey();

            //#1.6
            Console.WriteLine("1.6");
            int qq, bb, cc;
            qq = 7; bb = 15; cc = 100;
            Console.WriteLine($"{qq}  {bb}  {cc}");

            //#1.7
            Console.WriteLine("1.7");
            int w, r, t;
            Random rnd = new Random();
            w = rnd.Next();
            r = rnd.Next();
            t = rnd.Next();
            Console.WriteLine($"{w}  {r}  {t}");

            //#1.8
            Console.WriteLine("1.8");
            int ww, rr, tt, uu;
            ww = rnd.Next();
            rr = rnd.Next();
            tt = rnd.Next();
            uu = rnd.Next();
            Console.WriteLine($"{ww} {rr} {tt} {uu}");

            //#1.9
            Console.WriteLine("1.9");
            int k, l;
            k = 50; l = 10;
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.ReadKey();

            //#1.10
            Console.WriteLine("1.10");
            int s, d, f;
            s = 5; d = 10; f = 21;
            Console.WriteLine(s);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.ReadKey();

            //#1.11
            Console.WriteLine("1.11");
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
            Console.WriteLine("1.12");
            int hh, vv, nn;
            hh = 5; vv = 10; nn = 7;
            Console.WriteLine(hh + "\n");
            Console.WriteLine(vv + "\n");
            String dim = "см";
            Console.WriteLine($"{nn} {dim}  \n");
            Console.ReadKey();

            //#1.13
            Console.WriteLine("1.13");
            int hhh, vvv, nnn;
            hhh = 2; vvv = 13; nnn = 17;
            String sim = "кг";
            Console.WriteLine($"{hhh} {sim} \n");
            Console.WriteLine($"{vvv} {nnn}");
            Console.ReadLine();


            //#2.1
            Console.WriteLine("2.1");
            Console.Write("Введите значение x: ");
            double x21 = Convert.ToInt32(Console.ReadLine());
            double y21 = 7 * Math.Pow(x21, 2) + 3 * x21 + 6;
            Console.WriteLine($"{y21}");

            Console.Write("Введите значение А: ");
            double xb = Convert.ToInt32(Console.ReadLine());
            double func = 12 * Math.Pow(xb, 2) + 7 * xb + 12;
            Console.WriteLine($"{func}");
            Console.ReadLine();


            //#2.2
            Console.WriteLine("2.2");
            Console.Write("Сторона квадрата: ");
            double zzz = double.Parse(Console.ReadLine());
            double p = 4 * zzz;
            Console.Write("Периметр: " + p);
            Console.ReadKey(true);
            Console.ReadLine();


            //#2.3
            Console.WriteLine("2.3");
            Console.Write("Радиус: ");
            double bbb = double.Parse(Console.ReadLine());
            double dd = 2 * bbb;
            Console.Write("Диаметр: " + dd);
            Console.ReadKey(true);
            Console.ReadLine();

            //2.4
            Console.WriteLine("2.4");
            Console.Write("Высота: ");
            double v24 = Convert.ToInt32(Console.ReadLine());
            double rad = 6350;
            double bg = Math.Sqrt(Math.Pow(v24 + rad, 2) - Math.Pow(rad, 2));
            Console.WriteLine($"{bg}");
            Console.ReadLine();


            //#2.5
            Console.WriteLine("2.5");
            Console.Write("Длина ребра куба: ");
            double bnm = double.Parse(Console.ReadLine());
            Console.WriteLine("Объём куба: " + Math.Pow(bnm, 3).ToString());
            Console.WriteLine("Площадь поверхности = " + Math.Pow(bnm, 2) * 6);
            Console.ReadLine();

            //#2.6
            Console.WriteLine("2.6");
            Console.Write("Радиус: ");
            double rrr = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double dl = 2 * pi * rrr;
            Console.Write("Длина окружности: " + dl);
            Console.WriteLine("Площадь круга: " + Math.Pow(rrr, 2) * pi);
            Console.ReadLine();

            //#2.7
            Console.WriteLine("2.7");
            Console.Write("Введите первое число: ");
            double ch1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double ch2 = Convert.ToInt32(Console.ReadLine());
            double ch3 = ch1 + ch2;
            Console.WriteLine("Среднее арифметическое этих чисел: " + ch3 / 2);
            double ch4 = ch1 * ch2;
            Console.WriteLine("Среднее геометрическое этих чисел: " + Math.Sqrt(ch4));
            Console.ReadLine();

            //#2.8
            Console.WriteLine("2.8");
            Console.Write("Объём: ");
            double ob = Convert.ToInt32(Console.ReadLine());
            Console.Write("Масса: ");
            double ms = Convert.ToInt32(Console.ReadLine());
            double pl = ms / ob;
            Console.WriteLine("Плотность: " + pl);
            Console.ReadLine();

            //#2.9
            Console.WriteLine("2.9");
            Console.Write("Количество жителей: ");
            double ld = Convert.ToInt32(Console.ReadLine());
            Console.Write("Площадь: ");
            double pls = Convert.ToInt32(Console.ReadLine());
            double plns = ld / pls;
            Console.WriteLine("Плотность населения: " + plns);
            Console.ReadLine();

            //#2.10
            Console.WriteLine("2.10");
            Console.Write("Ax+B=0");
            Console.Write("Введите значение А: ");
            double pra = double.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            double prb = double.Parse(Console.ReadLine());
            double otv = (-prb) / (pra);
            Console.WriteLine($"x равен {otv}");

            //#2.11
            Console.WriteLine("2.11");
            Console.Write("Введите значение катета А: ");
            double kata = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение катета B: ");
            double katb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Гипотенуза: " + Math.Sqrt((Math.Pow(kata, 2) + Math.Pow(katb, 2))));
            Console.ReadLine();

            //#2.12
            Console.WriteLine("2.12");
            Console.Write("Введите внешний радиус кольца: ");
            double RR = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите внутренний радиус кольца: ");
            double rR = Convert.ToInt32(Console.ReadLine());
            double square = pi * (Math.Pow(RR, 2) - Math.Pow(rR, 2));
            Console.WriteLine("Площадь кольца: " + square);
            Console.ReadLine();

            //#2.13
            Console.WriteLine("2.13");
            Console.Write("катет a: ");
            double kateta = Convert.ToInt32(Console.ReadLine());
            Console.Write("катет b: ");
            double katetb = Convert.ToInt32(Console.ReadLine());
            double katetc = Math.Sqrt(Math.Pow(kateta, 2) + Math.Pow(katetb, 2));
            double perim = kateta + katetb + katetc;
            Console.WriteLine("Периметр: " + perim);
            Console.ReadLine();


            //2.13A
            Console.WriteLine("2.13a");
            Console.Write("Введите первое число: ");
            double ch11 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double ch22 = Convert.ToInt32(Console.ReadLine());
            if (ch11 < 0)
                ch11 = -ch11;
            if (ch22 < 0)
                ch22 = -ch22;
            Console.WriteLine("Среднее арифметическое модулей этих чисел: " + (ch11 + ch22) / 2);
            Console.WriteLine("Среднее геометрическое модулей этих чисел: " + Math.Sqrt(Math.Pow(ch11, ch22)));
            Console.ReadLine();

            //2.14
            Console.WriteLine("2.14");
            Console.Write("Основание мал: ");
            double osnmal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Основание бол: ");
            double osnbol = Convert.ToInt32(Console.ReadLine());
            Console.Write("Высота: ");
            double vs = Convert.ToInt32(Console.ReadLine());
            double ostatok = osnbol - osnmal;
            double bk = Math.Sqrt(Math.Pow(ostatok, 2) + Math.Pow(vs, 2));
            Console.WriteLine("Периметр трапеции: " + osnmal + osnbol + 2 * bk);
            Console.ReadLine();

            //2.14a
            Console.WriteLine("2.14А");
            Console.Write("сторона а: ");
            double stra = Convert.ToInt32(Console.ReadLine());
            Console.Write("сторона b: ");
            double strb = Convert.ToInt32(Console.ReadLine());
            double perpr = 2 * stra + 2 * strb;
            Console.WriteLine("Периметр: " + perpr);
            Console.WriteLine("Диагональ: " + Math.Sqrt(Math.Pow(stra, 2) + Math.Pow(strb, 2)));
            Console.ReadLine();

            //2.15
            Console.WriteLine("2.15");
            Console.Write("Введите первое число: ");
            double cha = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double chb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{cha + chb} {cha - chb} {cha * chb} {cha / chb}");
            Console.ReadLine();


            //2.16
            Console.WriteLine("2.16");
            Console.Write("Введите а: ");
            double sta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            double stb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите с: ");
            double stc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Объём: " + sta * stb * stc);
            Console.WriteLine("Площадь боковой поверхности: " + (2 * sta * stb) + (2 * sta * stc) + (2 * stb * stc));
            Console.ReadLine();

            //2.17
            Console.WriteLine("2.17");
            Console.Write("x1 = ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToInt32(Console.ReadLine());
            double rast = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние = " + rast);
            Console.ReadLine();


            //2.19
            Console.WriteLine("2.19");
            Console.Write("меньшее основание: ");
            double malosn = Convert.ToInt32(Console.ReadLine());
            Console.Write("большее основание: ");
            double bolosn = Convert.ToInt32(Console.ReadLine());
            Console.Write("угол: ");
            double ugol = Convert.ToInt32(Console.ReadLine());
            double tg = Math.Tan(ugol);
            double hHh = ((bolosn - malosn) / 2) * tg;
            double trapplo = 0.5 * (bolosn + malosn) * hHh;
            Console.WriteLine("Площадь: " + trapplo);
            Console.ReadLine();

            //2.20
            Console.WriteLine("2.20");
            Console.Write("x1= ");
            double X11 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1= ");
            double y11 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2= ");
            double x22 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2= ");
            double y22 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x3= ");
            double x33 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3= ");
            double y33 = Convert.ToInt32(Console.ReadLine());
            double AB = Math.Sqrt(Math.Pow(x22 - X11, 2) + Math.Pow(y22 - y11, 2));
            double BC = Math.Sqrt(Math.Pow(x33 - x22, 2) + Math.Pow(y33 - y22, 2));
            double AC = Math.Sqrt(Math.Pow(x33 - X11, 2) + Math.Pow(y33 - y11, 2));
            double pertri = AB + BC + AC;
            double polpertri = pertri / 2;
            Console.WriteLine("Периметр: " + pertri);
            double plotri = Math.Sqrt(polpertri * (polpertri - AB) * (polpertri - BC) * (polpertri - AC));
            Console.WriteLine("Площадь: " + plotri);
            Console.ReadLine();


            //2.21
            Console.WriteLine("2.21");
            Console.Write("x1= ");
            double x211 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1= ");
            double y211 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2= ");
            double x212 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2= ");
            double y212 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("x3= ");
            double x213 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3= ");
            double y213 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x4= ");
            double x214 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y4=");
            double y214 = Convert.ToInt32(Console.ReadLine());
            x211 = x212; y212 = y213; x213 = x214; y214 = y211;
            double ab = y212 - y211;
            double bc = x213 - y212;
            double cd = y214 - y213;
            double ad = x214 - x211;
            double sabc = 0.5 * ab * bc;
            Console.WriteLine("Площадь = " + 2 * sabc);
            Console.ReadLine();

            //2.22
            Console.WriteLine("2.22");
            Console.Write("Цена конфет= ");
            double konf = Convert.ToInt32(Console.ReadLine());
            Console.Write("цена печенья= ");
            double pech = Convert.ToInt32(Console.ReadLine());
            Console.Write("цена яблок= ");
            double apples = Convert.ToInt32(Console.ReadLine());
            Console.Write("сколько конфет x= ");
            double xkonf = Convert.ToInt32(Console.ReadLine());
            Console.Write("сколько печенья y= ");
            double ypech = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько яблок z = ");
            double zaplles = Convert.ToInt32(Console.ReadLine());
            double stoim = konf * xkonf + pech * ypech + zaplles * apples;
            Console.WriteLine("Общая стоисмость = " + stoim);
            Console.ReadLine();

            //2.23
            Console.WriteLine("2.23");
            Console.Write("Стоимость монитора= ");
            double monitor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Стоимость системного блока= ");
            double sistem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Стоимость клавиатуры= ");
            double klava = Convert.ToInt32(Console.ReadLine());
            Console.Write("Стоимость мыши = ");
            double mysh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стоимость 3 комплектов= " + 3 * monitor + 3 * sistem + 3 * mysh + 3 * klava);
            Console.Write("Количество комплектов= ");
            double lecti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стоимость всех комплектов= " + lecti*(mysh + klava + monitor + sistem));
            Console.WriteLine();

            //2.24
            Console.WriteLine("Задание 2.24");
            Console.Write("Введите возраст Тани = ");
            double Tanya = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите возраст Мити = ");
            double Mitya = Convert.ToInt32(Console.ReadLine());
            double sredvozrast = (Tanya + Mitya) / 2;
            double otlichie1 = Tanya - sredvozrast;
            double otlichie2 = Mitya - sredvozrast;
            Console.WriteLine($"Средний возраст- {sredvozrast}, возраст Тани отличается на {otlichie1}, возраст Мити отличается на { otlichie2}");


            //2.25
            Console.WriteLine("Задание 2.25");
            Console.Write("Введите первую скорость = ");
            double V1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую скорость");
            double V2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние");
            double rasst = Convert.ToInt32(Console.ReadLine());
            double time = rasst / (V1 + V2);
            Console.WriteLine($"Время сближения {time}");

            //2.26 
            Console.WriteLine("Задание 2.26");
            Console.Write("Введите первую скорость");
            double v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую скорость");
            double v2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние, на которое один другого обогнал");
            double rasstoyan = Convert.ToInt32(Console.ReadLine());
            var rasstoyanie = (rasstoyan + Math.Abs(v1 - v2) * 0, 5);
            Console.WriteLine($"Расстояние= {rasstoyanie}");

            //2.27 
            Console.WriteLine("Задание 2.27");
            Console.Write("Введите температуру по шкале Цельсия");
            double Celcia = Convert.ToInt32(Console.ReadLine());
            double j = 32;
            var Farengeit = (Celcia * 1, 8 + j);
            var Kelvin = Celcia + 273.15;
            Console.WriteLine($"По Фаренгейту {Farengeit}, по Кельвину {Kelvin}");

            //2.28
            Console.WriteLine("Задание 2.28");
            double Farengeit1 = 451;
            double Celcia1 = (double)((Farengeit1 / 1.8) - j);
            Console.WriteLine($"По Фаренгейту {Celcia1}");



























        }
    }
}
