// 8. We flew over to Titan

// new TitanTime(1000, 40) should be the same as new TitanTime(100, 40). We discard extra hours.
// new TitanTime(30, 70) should be the same as new TitanTime(31, 10). We turn extra minutes into hours.
// Printing time should be in format 000:00 i.e., with leading zeroes. So that new TitanTime(0, 0) gets printed as 000:00, new TitanTime(9, 11) is 009:11, new TitanTime(11, 7) is 011:07.

var time = new TitanTime(1000, 40);
PrintTime(time);

void PrintTime(TitanTime time)
{
    Console.WriteLine($"({time.Hours:000}:{time.Minutes:00})");
}
public class TitanTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public TitanTime(int hours, int minutes)
    {

        Hours = hours % 900;
        Minutes = minutes % 60;
        if (minutes > 60)
        {
            Hours = Hours + minutes / 60;
        }
    }
} 