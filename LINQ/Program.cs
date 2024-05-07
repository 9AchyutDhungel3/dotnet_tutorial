// Program.cs
class Program
{
    static void Main()
    {
        // LINQ: Language INtegrated Query

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Here Where and Select are LINQ operators.
        // We give lambda expression as paramter to them.

        // 1. Method syntax.
        var result1 = numbers.Where(num => num > 5).Select(num => num);

        // 2. Query expression syntax
        var result2 = from num in numbers
                      where num > 5
                      select num;

        // Restriction - where
        var result22 = from num in numbers
                       where num > 5 && num < 9
                       select num;

        // Projections/mapping - select
        // To find the square of the numbers in the array - numbers.
        var result3 = from num in numbers
                      select num * num;
        // To find the square of the even numbers in the array
        var result4 = from num in numbers
                      where num % 2 == 0
                      select num * num;

        // Ordering
        // Ascending: 'orderby'
        // Descending: 'orderby descending'
        var result5 = from num in numbers
                      orderby num descending
                      select num;

        // Partitioning: skip, take
        var result6 = numbers.Take(5); // take first five numbers.
        var result7 = numbers.Skip(3).Take(5);
        var result8 = numbers.Any(num => num % 2 == 0);
        var result9 = numbers.All(num => num % 2 == 0);

        // Console.WriteLine(result9);        
    }

    public void LearnLINQOnComplexCollection()
    {

        Country c1 = new Country(name: "Nepal",
                                 capital: "KTM",
                                 continent: "Asia",
                                 population: 2999999);
        Country c2 = new Country(name: "India",
                                 capital: "Delhi",
                                 continent: "Asia",
                                 population: 2999999999);
        Country c3 = new Country(name: "Germany",
                                 capital: "Berlin",
                                 continent: "Europe",
                                 population: 23432433);
        Country c4 = new Country(name: "France",
                                 capital: "Paris",
                                 continent: "Europe",
                                 population: 235432433);
        Country c5 = new Country(name: "Iran",
                                 capital: "Tehran",
                                 continent: "Asia",
                                 population: 234352433);

        List<Country> countries = new List<Country>()
        {
            c1,
            c2,
            c3,
            c4,
            c5
        };

        // List all asian countries:-
        var asianCountries = from country in countries
                             where country.Continent == "Asia"
                             select country.Name; // We are only concerned with the country name and not other properties of the items in the list

        // Console.WriteLine(asianCountries);


        // List all asian countries' names which have never been invaded:-
        var neverInvadedCountry = from country in countries
                                  where country.IndependenceDay == default
                                  select country.Name;
    }
}