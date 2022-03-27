using MealsharingNET.Models;

namespace MealsharingNET;

public class InMemoryMealRepository : IMealRepository
{
    private List<Meal> Meals { get; set; } = new List<Meal>(){
        new Meal()
        {
            ID=1,
            Title="Pizza",
            Description="Great Italian Pizza",
            Price= 139,
            Location="Amager",
            MaxReservations= 5
        },
        new Meal()
        {
            ID=2,
            Title="Pasta",
            Description="Italian Pasta",
            Price= 130,
            Location="Orestad",
            MaxReservations= 10
        }

    };

    public IEnumerable<Meal> ListMeals()
    {
        return Meals;
    }
    public void Add(Meal m)
    {
        Meals.Add(m);
    }
    public IEnumerable<Meal> GetMeal(int id)
    {
        return Meals.Where(m => m.ID == id);
    }
}