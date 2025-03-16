namespace FormatExceptionApp;

class Program
{
    static void Main(string[] args)
    {
        int num;

        while (true)
        {
            try
            {
                Console.WriteLine("Please enter a number ( 0 to Quit )");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You inserted {0}", num);
                if (num == 0)
                    break;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}