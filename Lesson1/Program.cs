using System;

namespace Lesson1
{
    class Program
    {
        //1. Создать пустой проект в  и прописать метод Main();
        static void Main(string[] args)
        {
            //2.Создать переменные всех пройденных типов данных, и инициализировать их значения;
            sbyte sb = -100; //1b
            byte b = 200; //1b
            short sh = -32000;//2b
            ushort us = 64000;//2b
            int i = -2_000_000_000;//4b
            uint ui = 4_000_000_000u;//4b
            long l = -9_000_000_000_000_000_000l;//8b
            ulong ul = 18_000_000_000_000_000_000ul;//8b
            decimal d = 10000000000000000000.2m;//16b
            float f = 12.123f;//4b
            double dg = 12.1232132131231231;//8b
            char s = 's';//2b
            string name = "Saint Nickola" + s;
            bool bo = true;

            
            Calculate(b, sh, ui, dg);
            bo = IsSumFrom10To20(sb, us);
            PrintNegativeOrPositive(i);
            IsNegative(l);
            SayHello(name);
            PrintIsYearLeap(2024);
            //delay
            Console.ReadKey();
        }
        
        //3. Написать метод вычисляющий выражение a* (b + (c / d)) и возвращающий результат,где a, b, c, d – входные параметры этого метода;
        static double Calculate(double multiplicanda, double summand, double dividend, double divisor)
        {
            double result = multiplicanda * (summand + (dividend / divisor));
            return result;
        }

        //4. Написать метод, принимающий на вход два числа, и проверяющий что их сумма лежит в пределах от 10 до 20(включительно),
        //если да – вернуть true, в противном случае – false;
        static bool IsSumFrom10To20(double summand1, double summand2)
        {
            double sum = summand1 + summand2;
            bool isSumFrom10To20 = sum >= 10 && sum <= 20;
            return isSumFrom10To20;
        }
        //5. Написать метод, которому в качестве параметра передается целое число, метод должен напечатать в консоль положительное ли число передали, или отрицательное;
        //Замечание: ноль считаем положительным числом.

        static void PrintNegativeOrPositive(long number)
        {
            string answer = number >= 0 ? "positive" : "negative";
            Console.WriteLine($"{ number} is a {answer} number.");
        }

        //6. Написать метод, которому в качестве параметра передается целое число, метод должен вернуть true, если число отрицательное;
        static bool IsNegative(long number)
        {
            bool isNegative = number < 0;
            return isNegative;
        }
        //7. Написать метод, которому в качестве параметра передается строка, обозначающая имя, метод должен вывести в консоль сообщение «Привет, указанное_имя!»;
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        //        8. * Написать метод, который определяет является ли год високосным, и выводит сообщение в консоль.
        //        Каждый 4-й год является високосным,
        //        кроме каждого 100-го,
        //        при этом каждый 400-й – високосный.
        static void PrintIsYearLeap(int year)
        {
            bool isYear4multiple = year%4 == 0;
            bool isYear100multiple = year%100 == 0;
            bool isYear400multiple = year % 400 == 0;
            bool isYearLeap = isYear400multiple || isYear4multiple && !isYear100multiple;
            string answer = isYearLeap ? "leap" : "not leap";
            Console.WriteLine($"The year is {answer}");
        }

    }
}
