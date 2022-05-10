using System.ComponentModel.DataAnnotations;

namespace MealsharingNET.Models;

public class Meal
{
    public int ID { get; set; }

    [Required]
    [MaxLength(20)]
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    [Range(0, 20)]
    public int MaxReservations { get; set; }
    public decimal Price { get; set; }
    public string Location { get; set; }

};