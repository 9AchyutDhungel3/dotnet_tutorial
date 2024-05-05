using System;

class IterationStatement
{
    static void Main1()
    {
        IterationStatement ItSt = new IterationStatement();
        // ItSt.LearnForLoop();
        ItSt.LearnWhileLoop();

    }
    void LearnForLoop()
    {
        // for(int i = 0 ; i < 10 ; i++)
        // {
        //     Console.WriteLine("I am human. ");
        // }

        // We can also use a better method : - foreach

        int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (int x in numberArray)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even. ");
            }
            else
            {
                Console.WriteLine($"{x} is odd. ");
            }
        }
    }

    void LearnWhileLoop()
    {
        int i = 0;
        while (i < 10)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even. ");
            }
            else
            {
                Console.WriteLine($"{i} is odd. ");
            }
            i++;
        }
    }

}