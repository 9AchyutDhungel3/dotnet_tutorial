// Best practice is to make one file per one class.

class Array
{
    void learn1DA()
    {
        int[] ages = new int[10]; //fixed sized array
        double[] ages2 = new double[10];

        ages[0] = 32;
        ages2[2] = 45;

        // float[] ages3 = new float[] {23.32f, 43.43f}; // not fixed size
        // you can also do it in the short form 
        float[] ages3 = {23.32f, 43.43f};
        

    }

    void learnMDArray()
    {
        // Two dimensional array
        int[,] agesMatrix = new int[10, 15];
        agesMatrix[0,0] = 343; // This is how we assign values to the cell in matrix

        string[,] name = new string[,] {{"ram","chandra"},{"hari","basnet"}};

        // Three dimensional array
        int[,,] agesMatrix3D = new int[10, 12, 15];

    }

    void learnJaggedArray()
    {
        byte[][] personAges = new byte[3][];
        
        personAges[0] = new byte[] {123};
        personAges[1] = new byte[] {33, 43};
        personAges[2] = new byte[] {3,4,2,3,3};
    }

}