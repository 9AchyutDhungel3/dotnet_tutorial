class SelectionStatement
{
    // There can only be a single entry point in the program.
    static void Main1()
    {
        // Create an instance 
        SelectionStatement ss = new SelectionStatement();
        // ss.LearnIfElse();
        // ss.LearnSwitch();
    }
    void LearnIfElse()
    {
        Console.WriteLine("Enter any number: ");
        string input = Console.ReadLine();
        byte x = byte.Parse(input);


        if (x == 34)
        {
            Console.WriteLine("I am inside if statement");
        }
        else
        {
            Console.WriteLine("I am inside else statement");
        }
    }

    void LearnSwitch()
    {
        Console.WriteLine("Enter an option: ");
        string option_s = Console.ReadLine();
        char option = char.Parse(option_s);
        switch (option)
        {
            // We can group cases like this if we have same task for different switch cases.
            case 'n':
            case 'N':
                Console.WriteLine("You opted for no");
                break;

            case 'y':
            case 'Y':
                Console.WriteLine("You opted for yes");
                break;

            default:
                break;


        }
    }
}