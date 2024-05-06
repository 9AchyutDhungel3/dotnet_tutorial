
//Base class
// public class Shape
// {
//     public double GetArea() => 0.0; 

//     public double GetPerimeter() => 0.0;
// }

// We can't instantiate an abstract class. 
// We can't declare a body in abstract method. 
// Abstract methods are declared inside abstract classes.
public abstract class Shape
{
    public abstract double GetArea(); //

    public abstract double GetPerimeter();
    
    public virtual void PrintResult()
    {
        Console.WriteLine("Printing result for some shape...");
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    // Constructor
    public Rectangle(double length, double breadth) 
    {
        Length = length;
        Breadth = breadth;
    }
    public override double GetArea() => Length * Breadth;

    public override double GetPerimeter() => 2 * (Length + Breadth);

    public override void PrintResult()
    {
        Console.WriteLine($"Printing result for rectangle [{Length}X{Breadth}]");
        Console.WriteLine($"Area: {this.GetArea()}");
        Console.WriteLine($"Perimeter: {this.GetPerimeter()}");
    }
}

public class Square : Rectangle
{
    public Square(double side) : base(side, side) // calls the base constructor
    {}
}


public class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius; // Expression body syntax.
    }

    // throw new NotImplementedException();

    public override double GetPerimeter() => 2 * Math.PI * Radius;
    // throw new NotImplementedException();

}
