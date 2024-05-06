using LearnCollection;

public class Country
{
    public string Name { get; set; }
    public int  Population { get; set; }

    public static readonly bool IsOnEarth = true; 

    // Instance constructor: used to create instances.
    // Default constructor (takes no parameter)
    public Country()
    {}

    // Parameterized Constructor
    public Country(string name)
    {
        Name = name;
    }

    public Country(string name, int population)
    {
        Name = name;
        Population = population;
    }

    // Static constructor
    // Executes only one time.
    // If you create multiple instances/objects of the class(like country1 and country2 below of the class Country) then the static constructor only executes the first time(when country1 is created but not when country2 is created). Whereas the other constructor are called each time a new instance is created.
    static Country()
    {
        
    }
}

public class Demo
{
    void DoSomething()
    {
        Country country1 = new Country(); // This calls the default constructor.
        Country country2 = new Country("Nepal"); // This calls the parameterized constructor.
        // Static properties are accessed through class name rather than the object name. 
        // For eg: to access 'IsOnEarth' value 
        // country.IsOnEarth (WRONG !!!)
        // Country.IsOnEarth (Correct !)

    }
}