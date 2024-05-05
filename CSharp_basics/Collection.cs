using System.Collections.Generic;

namespace LearnCollection
{
    public class Collection
    {
        public void LearnLists()
        {
            // We can initialize a list of basic type (here for eg. we have used byte built in data type)
            List<byte> ages = new List<byte> { 2, 3 };
            ages.Add(2);
            ages.Add(22);
            ages.Add(34);

            // Or we can also use our custom data type
            List<Country> countries = new List<Country>();
            Country country1 = new Country();
            countries.Add(country1);
            // Instead of assigning an object to a variable you can directly do:-
            // countries.Add(new Country() );

        }

        public void LearnDict()
        {
            Dictionary<string, string> countryCapital = new Dictionary<string, string>();
            
            countryCapital.Add("Nepal", "Kathmandu");
            countryCapital.Add("USA", "Washington");
            countryCapital.Add("India", "Delhi");

            // Equivalent way would be:----------------------------
            // Dictionary<string, string> countryCapital = new Dictionary<string, string>()
            // {
            //     ["Nepal"] = "Kathmandu",
            //     ["USA"] = "Washington",
            //     ["India"] = "Delhi"
            // };
            //-----------------------------------------------------

            foreach (var c in countryCapital)
            {
                Console.WriteLine($"Country: {c.Key}, Capital: {c.Value}");
            }
        }

    }
    public class Country
    {
        public string Name { get; set; }
    }

}