using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine($"Текущее время: {DateTime.Now}");

        var task1 = new Task(() =>
        {
            Console.WriteLine($"Задача запущена через метод Start: {DateTime.Now}");
        });
        task1.Start();

        var task2 = Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"Задача запущена через Task.Factory.StartNew: {DateTime.Now}");
        });

        var task3 = Task.Run(() =>
        {
            Console.WriteLine($"Задача запущена через Task.Run: {DateTime.Now}");
        });

        await Task.WhenAll(task1, task2, task3);
    }
}
