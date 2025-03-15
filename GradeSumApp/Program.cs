namespace GradeSumApp;

class Program
{
    static void Main(string[] args)
    {
        int gradePython = 0;
        int gradeCsharp = 0;
        int gradeJava = 0;
        int gradeSql = 0;
        int gradeAngular = 0;
        int average = 0;
        int totalLessons = 5;
        
        Console.WriteLine("Please insert the grade for Python");
        gradePython = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please insert the grade for csharp");
        gradeCsharp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please insert the grade for java");
        gradeJava = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please insert the grade for SQL");
        gradeSql = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please insert the grade for Angular");
        gradeAngular = Convert.ToInt32(Console.ReadLine());
        
        int gradesSum = gradePython + gradeCsharp + gradeJava + gradeSql + gradeAngular;
        if (gradesSum == 0 )
        {
            Console.WriteLine("Please insert grades > 0 , or you did not pass anything.");
        }
        Console.WriteLine("Your average is : "  + gradesSum / totalLessons );

        if (gradesSum != 0)
        {
            average = gradesSum / totalLessons;
            if (average > 10 || average < 0 )
            {
                Console.WriteLine("Average must be between 0 and 10.");
            }

            if (average >= 8)
            {
                Console.WriteLine($"Your average grade is  {average} -- Excellent");
            }
            else if (average >= 6)
            {
                Console.WriteLine($"Your average grade is  {average} -- Very good");
            }
            else if (average >= 5)
            {
                Console.WriteLine($"Your average grade is  {average} -- Good");
            }
            else if (average < 5)
            {
                Console.WriteLine($"Your average grade is  {average} -- Bad , Try again");
            }
        }
        Console.WriteLine($"Python : {gradePython}");
        Console.WriteLine($"C# : {gradeCsharp}");
        Console.WriteLine($"Java : {gradeJava}");
        Console.WriteLine($"Sql : {gradeSql}");
        Console.WriteLine($"Angular : {gradeAngular}");
        Console.WriteLine("-----------");
        Console.WriteLine($"Average : {average}");
    }
}