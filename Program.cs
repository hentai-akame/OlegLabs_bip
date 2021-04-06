using System;
using System.Collections.Generic;
using System.Linq;
namespace Oleg
{
    class Lab1
    {
        public Lab1() {
            Console.WriteLine("1 лаба");
            Console.Write("Введите a - ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("z1 = {0} \nz2 = {1}", z1(a), z2(a));
            Console.WriteLine("---------------------");
        }

        public double z1(double a)
        {
            return Math.Cos(a) + Math.Cos(2 * a) + Math.Cos(6 * a) + Math.Cos(7 * a);
        }
        public double z2(double a)
        {
            return 4 * Math.Cos(a / 2) * Math.Cos(5 / 2 * a) * Math.Cos(4 * a);
        }
    }

    class Lab2
    {
        public Lab2() {

            Console.WriteLine("2 лаба");
            Console.Write("Введите x - ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y - ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите z - ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B= {0}", B(x, y, z));
            Console.WriteLine("---------------------");

        }

        public double B(double x, double y, double z)
        {
            return Math.Sqrt(10) * (Math.Pow(x, 1.0 / 3.0) + Math.Pow(x, y + 2)) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));
        }
    }

    class Lab3
    {
        public Lab3()
        {
            Console.WriteLine("3 лаба");
            Console.Write("Введите x1 - ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2 - ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x3 - ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            z6(x1, x2, x3);
            Console.WriteLine("---------------------");

        }
        public void z6(double x1, double x2, double x3)
        {
            List<double> array = new List<double> { x1, x2, x3 };
            var sortarray = from i in array orderby i descending select i;
            List<double> temparray = new List<double> { };
            foreach (double i in sortarray) temparray.Add(i);
            double result = temparray[0] - temparray[temparray.Count - 1];
            Console.WriteLine("Разница - {0}", result);
        }
    }
    class Lab4
    {
        public Lab4()
        {
            Console.WriteLine("4 лаба");
            double xn = 0.1, xk = 1;
            z6(xn, xk);
            Console.WriteLine("---------------------");

        }
        public void z6(double xn, double xk)
        {
            Console.WriteLine("  x |   y");
            for (double x = xn; x < xk; x += 0.1)
                Console.WriteLine("{0:F1} | {1:F3}", x, Y(x));
        }
        public double Y(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x)) / 2;
        }
    }
    class Lab5
    {
        public Lab5()
        {
            Console.WriteLine("5 лаба");
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = FillArray(n, m);
            View(array, n, m);
            Zadanie(array, n, m);

        }

        public void Zadanie(int[,] array, int n, int m)
        {
            int[] maxelement = new int[3] { Int32.MinValue, 0, 0 };
            int[] minelement = new int[3] { Int32.MaxValue, 0, 0 };
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] > maxelement[0])
                    {
                        maxelement[0] = array[i, j];
                        maxelement[1] = i;
                        maxelement[2] = j;
                    }
                    if (array[i, j] < minelement[0])
                    {
                        minelement[0] = array[i, j];
                        minelement[1] = i;
                        minelement[2] = j;
                    }
                }
            }
            Console.WriteLine("Максимальный элемент - {0} \n Позиция {1},{2}", maxelement[0], maxelement[1] + 1, maxelement[2] + 1);
            Console.WriteLine("Минимальный элемент - {0} \n Позиция {1},{2}", minelement[0], minelement[1] + 1, minelement[2] + 1);

        }
        public void View(int[,] array, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == m - 1)
                        Console.Write("{0}\n", array[i, j]);
                    else
                        Console.Write("{0} ", array[i, j]);
                }
            }

        }

        public int[,] FillArray(int n, int m)
        {
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} Строка", i + 1);
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Массив заполнен");
            return array;
        }
    }

    class Lab6
    {
        public Lab6()
        {
            Console.WriteLine("6 лаба");
            Console.WriteLine("Строка S1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Строка S2");
            string s2 = Console.ReadLine();

            #region 1 способ
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.IndexOf(s2, i) == -1)
                    break;
                else
                {
                    count++;
                    i = s1.IndexOf(s2, i) + s2.Length;
                }
            }
            Console.WriteLine("Количество вхождений - {0}", count);
            #endregion
            #region 2 способ

            int StartLength = s1.Length;
            s1 = s1.Replace(s2, "");
            int LastLength = s1.Length;
            int resultCount = Math.Abs((LastLength - StartLength) / s2.Length);
            Console.WriteLine("Количество вхождений - {0}", resultCount);
            #endregion
        }
    }

    class Lab7
    {
        public struct Worker
        {
            public string Name;
            public string Surname;
            public string Work;
            public int following;
        }
        public int WorkersSort(Worker worker1, Worker worker2)
        {
            int Length = (worker1.Surname.Length > worker2.Surname.Length) ? worker2.Surname.Length : worker1.Surname.Length;
            for (int i = 0; i < Length; i++)
            {
                if (worker1.Surname[i] < worker2.Surname[i])
                {
                    return -1;
                }
                if (worker1.Surname[i] > worker2.Surname[i])
                    return 1;
            }
            return 0;

        }
        List<Worker> workers = new List<Worker> { };
        public Lab7()
        {
            Console.WriteLine("7 лаба");
            Menu();
        }
        public void AddWorker()
        {
            if (workers.Count != 10)
            {
                Worker worker = new Worker();
                Console.Write("Имя - ");
                worker.Name = Console.ReadLine();
                Console.Write("Фамилия - ");
                worker.Surname = Console.ReadLine();
                Console.Write("Работа - ");
                worker.Work = Console.ReadLine();
                Console.Write("Год поступления - ");
                worker.following = Convert.ToInt32(Console.ReadLine());
                workers.Add(worker);
                Console.WriteLine("Работник добавлен...");
                workers.Sort(WorkersSort);
            }
            else
            {
                Console.WriteLine("Больше добавлять нельзя!");
            }
        }

        public void ViewWorkers()
        {
            Console.WriteLine("Список работяг");
            foreach (Worker i in workers)
            {
                Console.WriteLine("Фамилия - {0}\nИмя - {1}\nПрофесия - {2}\nГод поступления - {3}\n", i.Surname, i.Name, i.Work, i.following);
                Console.WriteLine("--------------");
            }
        }
        public void Menu()
        {
            int answer = 0;
            while (answer != 4)
            {
                Console.WriteLine("1 - Заполнение работников\n2 - Вывод работников стаж работы превышающих...\n3 Вывод работяг\n4 Выход с проги");
                switch (answer = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        {
                            AddWorker();
                            break;
                        }
                    case 2:
                        {
                            FindWorker();
                            break;
                        }
                    case 3:
                        {
                            ViewWorkers();
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Что-то не то нажато");
                            break;
                        }
                }
            }
        }

        public void FindWorker()
        {
            Console.Write("Введите минимальный стаж - ");
            int followingTime = Convert.ToInt32(Console.ReadLine());
            var result = from i in workers where DateTime.Now.Year - i.following >= followingTime select i;
            List<Worker> Sworkers = new List<Worker>();
            foreach (Worker i in result)
                Sworkers.Add(i);
            if(Sworkers.Count!=0)
            foreach(Worker i in Sworkers)
            {
                Console.WriteLine("Фамилия - {0}\nИмя - {1}\nПрофесия - {2}\nСтаж - {3}\n", i.Surname, i.Name, i.Work, DateTime.Now.Year - i.following);
                Console.WriteLine("--------------");
            }
            else
            {
                Console.WriteLine("Таких нету");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Коментарий для Олега 
            // Классы lab и номер это номер лабы , то есть откоменчиваешь строку Lab1 lab1 = new Lab1() запускается код для первой лабы. Сам код находится в классе lab1. public Lab1() в нем хранится основной код. Остальное это функции которые я использовал
            //Lab1 lab1 = new Lab1();
            //Lab2 lab2 = new Lab2();
            //Lab3 lab3 = new Lab3();
            //Lab4 lab4 = new Lab4();
             //Lab5 lab5 = new Lab5();
            //Lab6 lab6 = new Lab6();
            Lab7 lab7 = new Lab7();

        }
    }
}
