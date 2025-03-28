

public class ConsoleUserInteractor : IUserInteractor
{
    public void PrintError(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadValidFile()
    {
        bool isFilePathValid = false;
        var fileName = default(string);

        do
        {

            Console.WriteLine("Enter the name of the file you want to read: ");
            fileName = Console.ReadLine();
            Console.Clear();

            if (fileName is null)
            {
                Console.WriteLine("The File Name cannot be Null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The File Name Cannot be Empty.");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine($"The File {fileName} does not exist.");
            }
            else
            {
                isFilePathValid = true;
            }

        } while (!isFilePathValid);
        return fileName;
    }
}
