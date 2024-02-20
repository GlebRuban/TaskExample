using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample
{
    class Task2and3
    {
        static void Main()
        {
            // Задание 2
            Task task1 = Task.Run(() =>
            {
                Console.WriteLine("Простые числа от 0 до 1000:");
                for (int i = 2; i <= 1000; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            });

            task1.Wait(); 
            // Задание 3
            int lowerBound = 1000;
            int upperBound = 2000;

            Task<int> task2 = Task.Run(() =>
            {
                int count = 0;
                for (int i = lowerBound; i <= upperBound; i++)
                {
                    if (IsPrime(i))
                    {
                        count++;
                    }
                }
                return count;
            });

            int primeCount = task2.Result;

            Console.WriteLine($"\nКоличество простых чисел от {lowerBound} до {upperBound}: {primeCount}");
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
