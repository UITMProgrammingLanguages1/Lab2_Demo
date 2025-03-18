Console.WriteLine("hello wORlD".ToSentenceCase());
Console.WriteLine("jaMes BoND".ToSentenceCase());
Console.WriteLine("marciN jaGiela".ToSentenceCase());

Console.WriteLine(4.IsOdd());
Console.WriteLine(5.IsOdd());
Console.WriteLine(7.IsOdd());

Console.WriteLine(DateTime.Today.NextDay());


public static class IntExtensions
{
    public static bool IsOdd(this int value)
    {
        return value % 2 != 0;
    }
}

public static class DateExtensions
{
    public static DateTime NextDay(this DateTime value)
    {
        return value.AddDays(1);
    }
}

//No way - string is sealed !!!

// public class BetterString : string
// {
//     public string ToSentenceCase()
//     {
//         //Bla bla bla
//     }
// }