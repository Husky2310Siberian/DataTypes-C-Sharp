namespace IgnoreSpaceApp;
/// <summary>
/// Ignores spaces
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int codeRead = 0;

        do
        {
            codeRead = Console.Read();
            if (codeRead != 0)
            {
                if (codeRead != 32)
                {
                    Console.Write($"{(char)codeRead}");
                }
            }
        } while (codeRead != 10);
    }
}