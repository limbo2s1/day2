using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                number += 5;
            }
            else
            {
                number -= 5;
            }

            //Задание 2
            Console.WriteLine("Введите 3 числа: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            int value3 = Convert.ToInt32(Console.ReadLine());

            if ((value1 > value2) && (value1 > value3))
            {
                Console.WriteLine("Первое число наибольшее.");
            }

            if ((value2 > value1) && (value2 > value3))
            {
                Console.WriteLine("Второе число наибольшее.");
            }

            else
            {
                Console.WriteLine("Третье число наибольшее.");
            }

            //Задание 3
            int result = 0;
            Console.WriteLine("Введите 3 числа: ");
            int values1 = Convert.ToInt32(Console.ReadLine());
            if (values1 > 0)
            {
                result += values1;
            }
            int values2 = Convert.ToInt32(Console.ReadLine());
            if (values2 > 0)
            {
                result += values2;
            }
            int values3 = Convert.ToInt32(Console.ReadLine());
            if (values3 > 0)
            {
                result += values3;
            }
            Console.WriteLine("Ответ: " + result);

            //Задание 4
            Console.WriteLine("Введите число: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            if (numbers > 10)
            {
                numbers = numbers * 2;
            }
            Console.WriteLine("Результат: " + numbers);

            //Задание 5
            Console.WriteLine("Введите число от 1 до 7: ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }

            //Задание 6
            for (int i = 200; i < 500; i++)
            {

                if (i % 17 == 0)
                {
                    Console.WriteLine("Число: " + i);
                    break;
                }
            }

            //Задание 7
            int targetDistance = 200; 
            double distance = 10000; 
            int day = 1; 

            while (distance < targetDistance)
            {
                distance += distance * 0.05; 

                if (distance > 100000)
                {
                    Console.WriteLine("В {0}-й день пробег превысит 100 км.", day);
                }

                day++;
            }
            Console.WriteLine("В {0}-й день пробег составит 20 км.", day);

            //Задание 8
            Console.WriteLine("Введите число: ");
            int numberss = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;

            for (int i = 2; i <= numberss; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Факториал число - " + numberss + " равен " + factorial);

            //Задание 9
            Console.WriteLine("Введите натуральное число: ");
            int nature = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; nature >= i; i++)
            {
                if (nature % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
