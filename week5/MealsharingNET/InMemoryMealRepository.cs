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

    public async Task<List<Meal>> ListMeals()
    {
        return await Task.FromResult(Meals);
    }
    public async Task Add(Meal m)
    {
       Meals.Add(m);
    }
    public async Task<Meal> GetMeal(int id)
    {
        return await Task.FromResult(Meals.FirstOrDefault(meal=>meal.ID == id));
    }
}