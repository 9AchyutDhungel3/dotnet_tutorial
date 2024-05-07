public class Country
{
    // Properties:-
    public string Name { get; set; }
    public string Capital { get; set; } 
    public string Continent { get; set; }
    public long Population { get; set; }
    public DateTime IndependenceDay { get; set; }

    // Methods:-
    // Constructor:-
    public Country(string name, string capital, string continent, long population, DateTime indieDay = default)
    {
        Name = name;
        Capital = capital;
        Continent = continent;
        Population = population;
        IndependenceDay = indieDay;
    }


}