using System.Diagnostics;

namespace AsyncAndParallel
{
    class Program
    {
        static void Main()
        {
            // MUltithreading
            // Thread thread = new Thread();

            // TPL - Task Parallel Library
            // Task task = new Task();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            // Sequential 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (int num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"Time taken (Sequential): {stopwatch.ElapsedMilliseconds} ms");

            // Parallel
            stopwatch.Restart();
            Parallel.ForEach(numbers, num => {
                Compute(num);
            });
            Console.WriteLine($"Time taken (Parallel): {stopwatch.ElapsedMilliseconds} ms");


        }

        static void Compute(int x)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Computed for :{x}");
        }
    }
}