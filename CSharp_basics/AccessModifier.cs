//By default class are internal ( can be used within a project.)
// If you want to use it outside a project use public.
using EnumsAndProperties;

class AccessModifier
{
    // By default methods are private.
    // If you want to use them within a project, then use internal keyword.
    // If you want to use them outside a project, then use public keyword.
    internal void DoSomething()
    {
        Console.WriteLine("Something is done! ");
    }

    public void DoAnotherThing()
    {
        DoSomething();
    }
}

class ModifierDemo
{
    void DoSomething()
    {
        // AccessModifier accessModifier = new AccessModifier();
        // // Before declaring internal .DoSomething() was inaccessible
        // accessModifier.DoSomething();
        Person person = new Person(); // Person class is defined in Properties.cs
        person.Age = 37;
        person.Age = 42;
    }

}