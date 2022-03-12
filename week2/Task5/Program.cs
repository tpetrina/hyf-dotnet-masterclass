// 5. Better printout

var time = new JupiterTime { Hours = 2, Minutes = 70 };
Console.WriteLine(time);

time.AddHours(1);
Console.WriteLine(time);
time.AddMinutes(65);
Console.WriteLine(time);
class JupiterTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }

    public override string ToString()
    {
        if(Minutes>59){
            Hours += Minutes/60;
            Minutes = Minutes % 60;
        }
        return "Time: " + Hours + ":" + Minutes;
    }

    public void AddHours(int hour){
         Hours +=hour;
    }
    public void AddMinutes(int minute){
         Minutes +=minute;
    }
}