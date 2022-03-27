namespace mealsharingNET;

using System.Threading.Tasks;
using Dapper;
using MealsharingNET;
using MealsharingNET.Models;
using MySql.Data.MySqlClient;

public class Mealrepository : IMealRepository
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
    public Task Add(Meal m)
    {
        Meals.Add(m);
        return Task.CompletedTask;
    }

    public Task<Meal> GetMeal(int id)
    {
        return Task.FromResult(Meals.FirstOrDefault(meal=>meal.ID == id));
    }

    public Task<List<Meal>> ListMeals()
    {
        return Task.FromResult(Meals);
    }
    //  public async Task<List<Meal>> ListMeals()
    // {
    //     await using var connection = new MySqlConnection(Shared.ConnectionString);
    //     var meals = await connection.QueryAsync<Meal>("SELECT id, name, price FROM products");
    //     return meals.ToList();
    // }
}