namespace Resume;

public class Utils
{
    public static readonly DateTime MyBirthDate = new(1996, 12, 20);
    public static int GetMyAge(DateTime? date = null) => (int)Math.Floor((date ?? DateTime.Now).Subtract(MyBirthDate).TotalDays / 365);
    public static int GetMyAge(DateOnly? date) => GetMyAge(date?.ToDateTime(new TimeOnly()));
}