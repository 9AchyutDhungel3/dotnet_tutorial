public class FileIO
{
    public void LearnFileReading()
    {
        // We CANNOT create a new instance of File class(it is implemented as static)
        // File file = new File();

        //verbatim character - @
        string absFilePath = @"C:\Users\ASUS TUF\OneDrive\Desktop\NetCentric\dotnet_tutorial\README.md";
        // Or we can also use :-
        //"C:\\Users\\ASUS TUF\\OneDrive\\Desktop\\NetCentric\\dotnet_tutorial\\README.md"
        string relFilePath = "Inheritance.cs";

        if (File.Exists(absFilePath))
        {
            var fileContent = File.ReadAllText(absFilePath);
            // Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(fileContent);
        }
        if (File.Exists(relFilePath))
        {
            var fileContent = File.ReadAllText(relFilePath);
            // Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(fileContent);
        }
    }

    public void LearnFileWriting()
    {
        string filePath = "fileWrite.txt";
        string fileContent = "Hello world!";
        File.AppendAllText(path: filePath, contents: fileContent);

    }

    public void LearnFileInfo()
    {
        string filePath = "fileWrite.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine(filePath);
        Console.WriteLine(size);
        Console.WriteLine(createdDate);

    }

    public void LearnDirectory()
    {
        string folderPath = "createdFolder";    
        Directory.CreateDirectory(folderPath);
        Directory.Delete(folderPath);
    }
}