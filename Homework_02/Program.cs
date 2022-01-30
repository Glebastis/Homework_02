using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "ДЗ_02 Бабенко";
            bool f = true;
            while (f)
            {
                Console.Clear();
                MakeForm();
                string taskNum = Console.ReadLine();
                switch (taskNum)
                {
                    case "1":
                        CompareTreeNumbers();
                        break;

                    case "2":
                        NumberOfDigits();
                        break;

                    case "3":
                        EvenCounter();
                        break;
                    case "4":
                        LogIn();
                        break;
                    case "5":
                        IMS();
                        break;
                    case "6":
                        GoodDigets();
                        break;
                    case "7":
                        recur();
                        break;

                    case "0":
                        f = false;
                        break;

                    default:
                        Console.Clear();
                        MakeCenterOutput("Номер задачи указан неверно. Повторите попытку", Console.WindowHeight/2);
                        Console.ReadLine();
                        break;

                }
            }
        }


        static void MakeForm()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int y = 3;
            MakeCenterOutput("============================", y);
            y += 1;
            MakeCenterOutput("====Домашнаяя работа #02====", y);
            y += 1;
            MakeCenterOutput("============================", y);
            y += 5;
            Console.ForegroundColor = ConsoleColor.White;
            MakeCenterOutput("==================================================", y);
            y += 1;
            MakeCenterOutput("============== Введите номер задачи ==============", y);
            y += 1;
            MakeCenterOutput("==================================================", y);
            y += 1;
            MakeCenterOutput("================= 1 ==> Задача 1 =================", y);
            y += 1;
            MakeCenterOutput("================= 2 ==> Задача 2 =================", y);
            y += 1;
            MakeCenterOutput("================= 3 ==> Задача 3 =================", y);
            y += 1;
            MakeCenterOutput("================= 4 ==> Задача 4 =================", y);
            y += 1;
            MakeCenterOutput("================= 5 ==> Задача 5 =================", y);
            y += 1;
            MakeCenterOutput("================= 6 ==> Задача 6 =================", y);
            y += 1;
            MakeCenterOutput("================= 7 ==> Задача 7 =================", y);
            y += 1;
            MakeCenterOutput("=================== 0 ==> Выход ==================", y);
            y += 1;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);

        }
        static void MakeCenterOutput(string str, int y)
        {
            Console.SetCursorPosition(CenterX(str), y);
            Console.WriteLine(str);
        }
        static int CenterX(string str)
        {
            return (Console.WindowWidth / 2) - (str.Length / 2);
        }
        static void CompareTreeNumbers()
        {
            Console.Clear();
            string str = "Бабенко Глеб";
            int y = 10;
            MakeCenterOutput(str, y);
            y += 1;
            str = "Написать метод, возвращающий минимальное из трёх чисел.";
            MakeCenterOutput(str, y);
            y += 1;
            str = "***";
            MakeCenterOutput(str, y);
            y += 1;
            str = "Введите первое число: ";
            MakeCenterOutput(str, y);
            y += 1;
            int oneCenterDigit = (Console.WindowWidth / 2);
            Console.SetCursorPosition(oneCenterDigit, y);
            double x1 = double.Parse(Console.ReadLine());
            str = "Введите второе число: ";
            y += 1;
            Console.SetCursorPosition(oneCenterDigit, y);
            MakeCenterOutput(str, y);
            y += 1;
            Console.SetCursorPosition(oneCenterDigit, y);
            double x2 = double.Parse(Console.ReadLine());
            y += 1;
            str = "Введите третье число: ";
            MakeCenterOutput(str, y);
            y += 1;
            Console.SetCursorPosition(oneCenterDigit, y);
            double x3 = double.Parse(Console.ReadLine());
            y++;

            double minimum;
            if (x1 > x2)
            {
                if (x3 > x2) { minimum = x2; }
                else { minimum = x3; };
            }
            else
            {
                if (x1 < x3) { minimum = x1; }
                else { minimum = x3; }
            }

            string res = "Наименьшее число из введенных трех - " + minimum.ToString();
            MakeCenterOutput(res, y);
            y += 1;
            Console.SetCursorPosition(oneCenterDigit, y);
            str = "***";
            MakeCenterOutput(str, y);
            y += 1;
            Console.SetCursorPosition(oneCenterDigit, y);
            str = "Нажмите Enter для завершения работы подпрограммы";
            MakeCenterOutput(str, y);
            Console.ReadLine();

        }
        static void NumberOfDigits()
        {
            Console.Clear();
            string str = "Бабенко Глеб";
            int y = 10;
            MakeCenterOutput(str, y);
            y += 1;
            str = "Написать метод подсчета количества цифр числа.";
            MakeCenterOutput(str, y);
            y += 1;
            MakeCenterOutput("Введите целое число", y);
            int oneCenterDigit = (Console.WindowWidth / 2);
            y += 1;
            Console.SetCursorPosition(oneCenterDigit, y);
            int x = int.Parse(Console.ReadLine());
            int counter = 0;
            while (x > 0)
            { x /= 10;
                counter += 1;
            }
            y++;
            str = "Введеное число состоит из " + counter + " числел";
            MakeCenterOutput(str, y);
            y++;
            Console.SetCursorPosition(oneCenterDigit, y);
            y += 1;
            str = "Нажмите Enter для завершения работы подпрограммы";
            MakeCenterOutput(str, y);
            Console.ReadLine();
        }

        static void EvenCounter() {
            Console.Clear();
            string str = "Бабенко Глеб";
            int y = 10;
            MakeCenterOutput(str, y);
            y += 1;
            str = "С клавиатуры вводятся числа, пока не будет введен 0.";
            y += 1;
            MakeCenterOutput(str, y);
            y += 1;
            str = "Подсчитать сумму всех нечетных положительных чисел.";
            MakeCenterOutput(str, y);
            y += 1;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);
            str = "Вводите целые числа один за другим";
            MakeCenterOutput(str, y);

            y += 1;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);

            int s = 0;
            int a = int.Parse(Console.ReadLine());
            y += 1;
            while (a != 0)
            {
                if (a > 0 && a % 2 == 1) 
                { 
                    s = s + a;
                    }
                Console.SetCursorPosition(Console.WindowWidth / 2, y);
                y += 1; 
                a = int.Parse(Console.ReadLine());
            }
            str = "Сумма нечетных положительных чисел равна: " + s;
            MakeCenterOutput(str, y);
            Console.SetCursorPosition(Console.WindowWidth / 2, y + 1);

            y += 1;
            str = "Нажмите Enter для завершения работы подпрограммы";
            MakeCenterOutput(str, y);
            Console.ReadLine();
        }

        static void LogIn()
        {
            Console.Clear();
            string str = "Бабенко Глеб";
            int y = 10;
            MakeCenterOutput(str, y);
            str = "Реализовать метод проверки логина и пароля.";
            y += 1;
            MakeCenterOutput(str, y);
            str = "С помощью цикла do while ограничить ввод пароля тремя попытками.";
            y += 1;
            MakeCenterOutput(str, y);
            y += 1;
            
            str = "Нажмите Enter для попытки войти в систему.";
            MakeCenterOutput(str, y);
            y += 1;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);
            Console.ReadLine();
            Console.Clear();

            y = 8;

            int count = 3;
            string login, password;
            do
            {
                if (count == 3 || count == 2)
                { 
                    str = $"Введите логин (осталось {count} попытки): ";
                    MakeCenterOutput(str, y);
                }
                else 
                {
                    str = $"Введите логин (осталось {count} попытка): ";
                    MakeCenterOutput(str, y);
                }
                y++;

                Console.SetCursorPosition(Console.WindowWidth / 2, y);
                login = Console.ReadLine();

                y++;
                str = "Введите пароль: ";
                MakeCenterOutput(str, y);
                y++;
                Console.SetCursorPosition(Console.WindowWidth / 2, y);
                password = Console.ReadLine();
                y++;

                bool res = ChekPass(login, password);

                if (res)
                {
                    count = 0;
                }
                else
                {
                    str = "Ошибка! Логин, или пароль неверны.";
                    MakeCenterOutput(str, y);
                    y++;
                    Console.SetCursorPosition(Console.WindowWidth / 2, y);
                    count --;
                }
            }
            while (count > 0);

            bool result = ChekPass(login, password);
            Console.Clear();
            y = 10;

            if (result)
            {
                str = "Success! Доступ предоставлен!";
                MakeCenterOutput(str, y);
                y += 1;
                str = "Нажмите Enter для завершения работы подпрограммы";
                MakeCenterOutput(str, y);
                Console.ReadLine();
            }
            else
            {
                str = "Доступ заблокировн! Обратитесь в поддержку.";
                MakeCenterOutput(str, y);
                y += 1;
                str = "Нажмите Enter для завершения работы подпрограммы";
                MakeCenterOutput(str, y);
                Console.ReadLine();
            }
            

        }

        static bool ChekPass(string login, string password)
        {

            if (login == "root" && password == "GeekBrains")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void IMS()
        {
            Console.Clear();
            int y = 10;
            string str = "Бабенко Глеб";
            MakeCenterOutput(str, y);
            y++;
            str = "Написать программу, которая запрашивает массу и рост человека, ";
            MakeCenterOutput(str, y);
            y += 1;
            str = "вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.";
            MakeCenterOutput(str, y);
            y += 1;

            str = "Введите свой вес (в килограммах) ";
            MakeCenterOutput(str, y);
            y++;
            Console.SetCursorPosition(Console.WindowWidth/2, y);
            double weight = double.Parse(Console.ReadLine());
            y += 1;
            str = "Какой у Вас рост? (в сантиметрах) ";
            MakeCenterOutput(str, y);
            y++;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);
            double tall = double.Parse(Console.ReadLine());
            y += 1;

            double imt = weight / (tall / 100 * tall / 100);

            str = $"Ваш индекс массы тела равен {imt:F2}";
            MakeCenterOutput(str, y);
            
            y++;

            if (imt < 18.5)
            {
                str = $"У вас недостаточная масса тела. " +
                    $"Для нормы необходимо набрать {(Math.Floor((18.5* (tall / 100 * tall / 100)) - weight))} килограммов";
                MakeCenterOutput(str, y);
            }
            else
            {
                if (imt > 25)
                {
                    str = $"У вас избыточная масса тела. " +
                    $"Для нормы необходимо сбросить {(Math.Ceiling(weight - (25.0 * (tall / 100 * tall / 100))))} килограммов";
                    MakeCenterOutput(str, y);
                }
                else
                {
                    str = "Ваш вес в норме";
                    MakeCenterOutput(str, y);
                }
            }
            str = "";
            y += 1;

            MakeCenterOutput(str, y);
            str = "Нажмите Enter для завершения работы подпрограммы";
            y += 1;

            MakeCenterOutput(str, y);

            System.Console.ReadLine();
            System.Console.Clear();

        }
        static void GoodDigets()
        {
            Console.Clear();
            int y = 10;
            string str = "Бабенко Глеб";
            MakeCenterOutput(str, y);
            y++;
            str = "Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.";
            MakeCenterOutput(str, y);
            y++;
            str = "«Хорошим» называется число, которое делится на сумму своих цифр.";
            MakeCenterOutput(str, y);
            y++;
            str = "Реализовать подсчёт времени выполнения программы, используя структуру DateTime.";
            MakeCenterOutput(str, y);
            y++;
            str = "Нажмите Enter для запуска подпрограммы";
            MakeCenterOutput(str, y);
            y += 1;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);
            Console.ReadLine();

            Console.Clear();

            DateTime start = DateTime.Now;
            int counter = 0;

            for (int i = 1; i <= 1000000000; i++)
            {
                int s = 0;
                int a = i;
                
                while (a > 0)
                {
                    s = s + a % 10;
                    a = a / 10;
                }
                //Console.WriteLine(i.ToString());
                //Console.WriteLine(s);
                if (i % s == 0)
                {
                    counter++;
                }
                


            }
            y = 15;
            str = $"Найдено {counter} \"Хороших\" числа";
            MakeCenterOutput(str, y);
            y += 1;
            str = (DateTime.Now - start).ToString();
            MakeCenterOutput(str, y);
            y+=1;
            str = "Нажмите Enter для завершения подпрограммы.";
            MakeCenterOutput(str, y);
            y += 1;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);
            Console.ReadLine();
        }
        
        static void recur()
        {
            Console.Clear();
            int y = 10;
            string str = "Бабенко Глеб";
            MakeCenterOutput(str, y);
            y++;
            str = "Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).";
            MakeCenterOutput(str, y);
            y++;
            str = "Разработать рекурсивный метод, который считает сумму чисел от a до b.";
            MakeCenterOutput(str, y);
            y++;
            str = "Введите число а:";
            MakeCenterOutput(str, y);
            y++;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);
            int a = int.Parse(Console.ReadLine());
            y++;
            str = "Введите число b:";
            MakeCenterOutput(str, y);
            y++;
            Console.SetCursorPosition(Console.WindowWidth / 2, y);
            int b = int.Parse(Console.ReadLine());
            Console.Clear();
            

            recur_a(a, b);
            int sum = recur_b(a, b);

            str = $"Сумма чисел от {a} до {b} равна {sum}";
            Console.WriteLine(str);
            Console.ReadLine();
        }
        static bool recur_a(int a, int b)
        {
            while(true)
            {
                if (a <= b)
                {
                    Console.WriteLine(a.ToString());
                    return recur_a(a + 1, b);
                }
                else
                {
                    return false;
                }
            }
            
        }
        static int recur_b(int a, int b)
        {
            int sum = a;
            if (a > b)
            {
                return 0;
            } 
            else
            {
                return sum + recur_b(a + 1, b);
            }

        }

    }
}
