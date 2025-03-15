namespace CharReadApp;
/// <summary>
/// Reads characters using Console.Read()
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        char inputChar;
        int charCode;

        do
        {
            charCode = Console.Read();
            inputChar = (char) charCode;
            Console.WriteLine($"char: {inputChar} -- charCode: {charCode}");
            
        }while (charCode != 10);
    }
}