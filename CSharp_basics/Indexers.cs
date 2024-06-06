
public class Matrix
{
    public int[,] data;

    //Constructor 
    public Matrix(int rows, int cols)
    {
        data = new int[rows, cols];
    }

    public int this[int rows, int cols]
    {
        get { return data[rows,cols];  }
        set { data[rows,cols] = value; }
    }

    static void Main()
    {
        Matrix obj = new Matrix(2,2);
        obj[0,0] = 5;
        Console.WriteLine(obj[0,0]);
    }

}