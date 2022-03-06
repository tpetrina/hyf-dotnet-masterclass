// 3. Adding time

var time = new JupiterTime(2, 20);
var timeIn1Hour = time.AddHours(1);

PrintTime(timeIn1Hour);

void PrintTime(string time)
{
    Console.WriteLine($"{time}");
} 
public class JupiterTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; } 
    public JupiterTime(int hours, int minutes){
        Hours = hours;
        Minutes=minutes;

        if(Minutes>59){
            Hours += minutes/60;
            Minutes = minutes % 60;
        }
    }

    public string AddHours(int hour){
         Hours +=hour;
         return ($"{Hours}:{Minutes}");
    }
}
