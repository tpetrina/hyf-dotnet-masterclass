namespace MealsharingNET.Models;

public class Review
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int MealID { get; set; }
    public DateTime CreatedDate { get; set; }

};