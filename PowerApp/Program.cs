using System.Numerics;

namespace PowerApp;
/// <summary>
/// Calculates a ^ b --> 2^10 = 1024
/// User gives a , b
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int myBase = 0;
        int myPower = 0;
        BigInteger result = 1;
        
        Console.WriteLine("Please enter a base and a power.");
        if (!int.TryParse(Console.ReadLine(), out myBase))
        {
            Console.WriteLine("invalid int");
        }
        if (!int.TryParse(Console.ReadLine(), out myPower))
        {
            Console.WriteLine("invalid int");
        }

        for (int i = 1; i <= myPower ; i++)
        {
            result*= myBase;
        }
        Console.WriteLine($"The result from base {myBase} ^ {myPower} = {result}");
    }
}