namespace MealsharingNET.Models;

public class Reservation
{
    public int ID { get; set; }
    public int MealID { get; set; }
    public DateTime CreatedDate { get; set; }
    public string ContactNumber { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int NumberOfGuests { get; set; }
} 