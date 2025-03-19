namespace OptionalParams;

class Program
{
    static void Main(string[] args)
    {
        DateTime date1 = GetDateTime();
        Console.WriteLine($"{date1:D}");
        
        DateTime date2 = GetDateTime();
        Console.WriteLine($"{date2:F}");
        
    }

    public static DateTime GetDateTime(int year=2025, int month=3, int day=18, int hour=0, int minute=0, int second=0, int millisecond=0)
    {
      return new DateTime(year, month, day, hour, minute, second, millisecond , DateTimeKind.Utc);
    }
}