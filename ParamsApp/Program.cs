namespace ParamsApp;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;
        result = Add(1, 3, 5, 7, 9);
        Console.WriteLine(result);
        
        result = Add(0, 2 , 4, 6 ,8);
        Console.WriteLine(result);
        
        Console.WriteLine("Hello, World!");
    }

    /// <summary>
    /// A type of overloading
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}