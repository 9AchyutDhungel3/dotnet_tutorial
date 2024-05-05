using EnumsAndProperties;

public class MethodLearn
{
    static void Main2()
    {
        MethodLearn methodLearn = new MethodLearn();
        // double sum = methodLearn.Sum(2.3,3.2);
        // Console.WriteLine($"Sum is: {sum}");

        // If we want to send list of number to a method:-------
        // int[] numList = {1,2,3,4,5,6};
        // double evenSum = methodLearn.EvenSum(numList);
        // Console.WriteLine($"Sum of even number is: {evenSum}");

        // If we want to send many and arbitrary numbers of parameters:-------------------
        // double paramEvenSum = methodLearn.EvenSum(1,2,3,4,5,6);
        // Console.WriteLine($"Sum of even number is: {paramEvenSum}");
        // double paramEvenSum1 = methodLearn.EvenSum(1,2,3,4,5,6,7,8);
        // Console.WriteLine($"Sum of even number is: {paramEvenSum1}");
        // double paramEvenSum2 = methodLearn.EvenSum(1,2,3,4,5,6,7,8,9,10);
        // Console.WriteLine($"Sum of even number is: {paramEvenSum2}");

        // int[] numbers = {23,24, 45, 98, 22, 904854};
        // (int min, int max) result = methodLearn.FindMinMax(numbers);
        // Console.WriteLine($"Min is {result.min} and max is {result.max}");
        methodLearn.Sum<float>(3.3f, 34.3f);
    }
    public double Sum(double x, double y)
    {
        DayWeek d;
        return x + y;
    }

    // Take six numbers list as input and return sum of the even numbers from that list.
    // public int EvenSum (int[] arr)
    // {
    //     int sum = 0;
    //     foreach (int x in arr)
    //     {
    //         if(x%2==0)
    //         {
    //             sum+=x;
    //         }
    //     }
    //     return sum;
    // }

    // If the input is not in list format, then we can use the following way:
    // We can send arbitrary number of parameters in this way(if we don't know beforehand how many arguments we are going to pass to the method.)
    public int EvenSum(params int[] nums) // Variable no. of arguments.
    {
        int sum = 0;
        foreach (int x in nums)
        {
            if (x % 2 == 0)
            {
                sum += x;
            }
        }
        return sum;
    }

    // Returning multiple values - Using tuples.
    // Eg: min and max
    internal (int, int) FindMinMax(int[] nums)
    {
        int min = nums[0];
        int max = nums[0];

        foreach (int num in nums)
        {
            min = num < min ? num : min;
            max = num > max ? num : max;
        }

        return (min, max);
    }

    // Generic method:
    public void Sum<T>(T x, T y)
    {

    }
}