using System.Xml;

namespace DataTypesApp;

class Program
{
    static void Main(string[] args)
    {
        int number = 5;
        switch (number)
        {
            case 1:
            case 4:
            case 6:
            case 8:
            case 10:
                Console.WriteLine("The number is not prime!");
                break;
            case 2:
            case 5:
            case 7:
                Console.WriteLine("The number is prime!"); 
                break;
            default: Console.WriteLine("Unknown number!");
                break;
        }
    }
}