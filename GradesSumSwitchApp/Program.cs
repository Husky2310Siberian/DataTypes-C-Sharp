namespace GradesSumSwitchApp;

class Program
{
    static void Main(string[] args)
    {
        int average;
        
        Console.WriteLine("Enter total grades and courses count");

        if (!int.TryParse(Console.ReadLine(), out int totalMarks))
        {
            Console.WriteLine("Error. Format mismatch");
        }

        if (totalMarks < 0)
        {
            Console.WriteLine("Error. Enter a positive number");
            Environment.Exit(1);
        }

        if (!int.TryParse(Console.ReadLine(), out int coursesCount))
        {
            Console.WriteLine("Error. Format mismatch");
        }

        if (coursesCount < 0)
        {
            Console.WriteLine("Error. Enter a valid number");
            Environment.Exit(1);
        }

        average = totalMarks / coursesCount;
        
        if (average > 10)
        {
                Console.WriteLine("Error. Enter a valid number");
        }

        switch (average)
        {
            case >= 8:
                Console.WriteLine($"Good job! {average}");
                break;
            case >= 6:
                Console.WriteLine($"nice try! {average}");
                break;
            case >= 5:
                Console.WriteLine($"merit!! {average}");
                break;
            default:
                Console.WriteLine($"Failure,  {average}");
                break;
        }
    }
}