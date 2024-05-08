using System.Diagnostics;

namespace AsyncAndParallel
{
    class Program
    {
        static void Main1()
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
            Parallel.ForEach(numbers, num =>
            {
                Compute(num);
            });
            Console.WriteLine($"Time taken (Parallel): {stopwatch.ElapsedMilliseconds} ms");

        }

        static void Compute(int x)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Computed for :{x}");
        }

        // static void Main2()
        // {
        // Make Tea
        // - Turn on burner(2s)
        // - PUt on kettle ( 1s )
        // Add water (2s)
        // boil it (3 min)
        // Grind tea masala (10s)
        // Add sugar and masalas (2s)
        // Add milk (2s)
        // Boil it (2 min)

        // Fry eggs
        // Turn on burner (2s)
        // Put on pan (1s)
        // Add oil (2s)
        // Crack eggs and stir it (2min)
        // fry it (1 min)

        // Everything ready : Serve it

        //----------------------------------------------------------------------
        // Sequential 
        //----------------------------------------------------------------------

        // Make tea: ----------

        //     TurnOnBurner();
        //     Console.WriteLine("Burner turned on.");

        //     PutOn("Kettle");
        //     Console.WriteLine("Kettle put on");

        //     Add("Water");
        //     Console.WriteLine("Water Added");

        //     Boil("Water");
        //     Console.WriteLine("Water boiled");

        //     GrindMasala();
        //     Console.WriteLine("Masala grinded");

        //     Add("Sugar and masala");
        //     Console.WriteLine("Added sugar and masala.");

        //     Add("milk");
        //     Console.WriteLine("Milk added.");

        //     Boil("It");
        //     Console.WriteLine("It is boiled");


        //     // Fry eggs: ----------

        //     TurnOnBurner();
        //     Console.WriteLine("Burner2 turned on.");

        //     PutOn("Pan");
        //     Console.WriteLine("Pan put on.");

        //     Add("oil");
        //     Console.WriteLine("Oil added.");

        //     CrackAndStirEggs();
        //     Console.WriteLine("Eggs cracked and stired.");

        //     FryEgg();
        //     Console.WriteLine("Eggs are fried.");

        // }

        // private static void FryEgg()
        // {
        //     Thread.Sleep(20000);
        // }

        // private static void CrackAndStirEggs()
        // {
        //     Thread.Sleep(10000);
        // }

        // private static void Boil(string item)
        // {
        //     Thread.Sleep(10000);
        // }

        // private static void Add(string item)
        // {
        //     Thread.Sleep(2000);
        // }

        // private static void GrindMasala()
        // {
        //     Thread.Sleep(10000);
        // }

        // private static void TurnOnBurner()
        // {
        //     Thread.Sleep(2000);
        // }

        // private static void PutOn(string container)
        // {
        //     Thread.Sleep(2000);
        // }







        //----------------------------------------------------------------------
        // Async Code
        //----------------------------------------------------------------------

        static async Task Main()
        {
            // Start stopwatch here: ----------
            Stopwatch st = Stopwatch.StartNew();

            Task turnOnBurner = TurnOnBurner();
            Task putOnKettle = PutOn("Kettle");
            Task addWater = Add("Water");
            Task boilWater = Boil("Water");
            Task grindMasala = GrindMasala();
            Task addSugarAndMasala = Add("Sugar and masala");
            Task addMilk = Add("milk");
            Task boilIt = Boil("It");
            Task turnOnBurner2 = TurnOnBurner();
            Task putOnPan = PutOn("Pan");
            Task addOil = Add("oil");
            Task crackAndStirEggs = CrackAndStirEggs();
            Task fryEgg = FryEgg();


            await turnOnBurner;
            Console.WriteLine("Burner turned on.");

            await putOnKettle;
            Console.WriteLine("Kettle put on");

            await addWater;
            Console.WriteLine("Water Added");

            await boilWater;
            Console.WriteLine("Water boiled");

            await grindMasala;
            Console.WriteLine("Masala grinded");

            await addSugarAndMasala;
            Console.WriteLine("Added sugar and masala.");

            await addMilk;
            Console.WriteLine("Milk added.");

            await boilIt;
            Console.WriteLine("It is boiled");

            await turnOnBurner2;
            Console.WriteLine("Burner2 turned on.");

            await putOnPan;
            Console.WriteLine("Pan put on.");

            await addOil;
            Console.WriteLine("Oil added.");

            await crackAndStirEggs;
            Console.WriteLine("Eggs cracked and stired.");

            await fryEgg;
            Console.WriteLine("Eggs are fried.");

            // Stop stopwatch here: ------------
            Console.WriteLine($"Time taken (parallel): {st.ElapsedMilliseconds} ms");
        }

        private static async Task FryEgg()
        {
            await Task.Delay(20000);
        }

        private static async Task CrackAndStirEggs()
        {
            await Task.Delay(10000);
        }

        private static async Task Boil(string item)
        {
            await Task.Delay(10000);
        }

        private static async Task Add(string item)
        {
            await Task.Delay(2000);
        }

        private static async Task GrindMasala()
        {
            await Task.Delay(10000);
        }

        private static async Task TurnOnBurner()
        {
            await Task.Delay(2000);
        }

        private static async Task PutOn(string container)
        {
            await Task.Delay(2000);
        }
    }
}