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

    // HW: Create a folder "Nepal", with in that create 10 sub folders. Every subfolders should contain a file Test.txt with subfolder name as content.
    public void HomeWork()
    {
        // Create root directory.
        string rootFolderPath = "Nepal";
        Directory.CreateDirectory(rootFolderPath);

        // 1. Create 10 new sub-directory
        // 2. Inside each sub-directory create a text file.
        // 3. Inside each of the text file add the content as the sub-directory name.
        for (int i = 0; i < 10; i++)
        {
            // Create a new sub-directory.
            string subFolderName = "subFolder" + i;
            string subFolderPath = rootFolderPath + @"\" + subFolderName;
            Directory.CreateDirectory(subFolderPath); // Created sub-directory with the given name and path.

            // Create text file and add the sub-folder name as it's content.
            string fileName = "Test.txt";
            File.WriteAllText(path: subFolderPath + @"\" + fileName, contents: subFolderName);
        }
    }
}