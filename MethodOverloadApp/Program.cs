namespace MethodOverloadApp;

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        float c = 10F;
        float d = 20F;
        
        PrintNums(a,c);
        PrintNums(c,d);
    }

    public static void PrintNums(int intVal, float floatVal)
    {
        Console.WriteLine(intVal +" , "+ floatVal);
    }

    public static void PrintNums(float intVal, float floatVal)
    {
        Console.WriteLine(intVal + " , "+ floatVal);
    }
}