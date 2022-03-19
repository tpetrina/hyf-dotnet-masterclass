// 7. We fell asleep! What should we do now?

var signaler = new Signaler();
signaler.AddTime(new JupiterTime(2, 00));
signaler.AddTime(new JupiterTime(4, 00));
signaler.AddTime(new JupiterTime(6, 00));
signaler.Check(new JupiterTime(1, 17));
signaler.Check(new JupiterTime(4, 21));


public class Signaler
{
    List<JupiterTime> Timelist = new List<JupiterTime>();
    List<JupiterTime> CheckTimelist = new List<JupiterTime>();
    public void AddTime(JupiterTime time){
         Timelist.Add(time);
    }
    public void Check(JupiterTime time){

         foreach (var item in Timelist)
         {
             if (time.Hours > item.Hours || (time.Hours == item.Hours && time.Minutes > item.Minutes))
            {
                CheckTimelist.Add(item);
            }
         }
         
         if (CheckTimelist.Count== 0) Console.WriteLine("No signals needed to be sent yet");
        else
        {
            foreach (var item in CheckTimelist)
            {
                Console.WriteLine(item);
            }
        }
    }
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
    public override string ToString()
    {
        return "Time: " + Hours + ":" + Minutes;
    }
}

