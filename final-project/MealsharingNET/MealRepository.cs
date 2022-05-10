using System.Threading.Tasks;
using Dapper;
using MealsharingNET;
using MealsharingNET.Models;
using MySql.Data.MySqlClient;
namespace mealsharingNET;


public class MealRepository : IMealRepository
{
    public async Task Add(Meal m)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var mealID = await connection.ExecuteAsync("INSERT INTO meals (Title, Description, Price, Location, Max_Reservations) VALUES (@Title, @Description, @Price, @Location, @MaxReservations)", m);
    }

    public async Task DeleteMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync("DELETE FROM Meals WHERE id=@CustomId", new { CustomId = id });
    }

    public async Task<Meal> GetMeal(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryFirstAsync<Meal>("SELECT id, title, Description, Price, Location, Max_Reservations FROM meals WHERE id=@CustomId", new { CustomId = id });
        return meal;
    }

    public async Task<List<Meal>> ListMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Meal>("SELECT id, title, Description, Price, Location, Max_Reservations FROM meals");
        return meals.ToList();
    }
}