// 9. Ganymede calls
var time = new JupiterTime  (2,70);
var time1 = new TitanTime (9,50);
var time2 = new GanymedeTime (8,80);
Console.WriteLine(time);
Console.WriteLine(time1);
Console.WriteLine(time2);

public abstract class AlienTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    private int HoursInDay { get; set; }

    public AlienTime(int hours, int minutes, int hoursInDay)
    {
        Hours=hours;
        Minutes=minutes;
        HoursInDay=hoursInDay;
    }

    public override string ToString()
    {
        var NumberOfDays=HoursInDay/171;
        if(Minutes>59){
            Hours += Minutes/60;
            Minutes = Minutes % 60;
        }
        return "Time: " + Hours + ":" + Minutes + " NumberOfDays: " + NumberOfDays;
    }

}

public class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
        : base(hours, minutes, 10)
    {}
}

public class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
        : base(hours, minutes, 900)
    {}
}

public class GanymedeTime : AlienTime
{
    public GanymedeTime(int hours, int minutes)
        : base(hours, minutes, 171)
    {}
}
