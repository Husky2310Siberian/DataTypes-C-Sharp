namespace ConsumesEnterWithReadLine;

class Program
{
    static void Main(string[] args)
    {
        char inputChar = ' ';

        do
        {
            Console.Write("Please insert a char:\n ");
            inputChar = (char) Console.Read();
            Console.ReadLine();
            Console.WriteLine($"You inserted char: \t{inputChar}\n");
        } while(inputChar != '*');
        Console.WriteLine("Bye");
    }
}