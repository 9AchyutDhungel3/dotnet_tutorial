
namespace EnumsAndProperties
{
    
    enum DayWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    internal class Demo
    {
        public DayWeek DayWeek { get; set; }
        void PrintGreetings()
        {
            if (DayWeek == DayWeek.Sunday)
            {
                Console.WriteLine("Its a good sunday. ");
            }
            else if (DayWeek == DayWeek.Saturday)
            {
                Console.WriteLine("Its a good saturday. ");

            }
            else
            {
                Console.WriteLine("Workday!");
            }
        }
    }
}