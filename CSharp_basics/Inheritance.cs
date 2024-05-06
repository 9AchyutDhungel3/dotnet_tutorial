
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
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double GetArea() => Length * Breadth;

    public override double GetPerimeter() => 2 * (Length + Breadth);
}

public class Square : Rectangle
{
    public Square(double side)
    {
        base.Breadth = side;
        base.Length = side;

    }
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
