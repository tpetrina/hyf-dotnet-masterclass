namespace mealsharingNET;

using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using MealsharingNET;
using MealsharingNET.Models;
using MySql.Data.MySqlClient;

public class ReviewRepository : IReviewRepository
{
    public async Task Add(Review review)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reviewId = await connection.ExecuteAsync("INSERT INTO reviews (id, title, description, meal_id, created_date ) VALUES (@ID, @Title, @Description, @MealID, @CreatedDate)", review);
    }

    public async Task<List<Review>> ListReviews()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reviews = await connection.QueryAsync<Review>("SELECT id, title, description, meal_id, created_date FROM reviews");
        return reviews.ToList();
    }

    public async Task<List<Review>> MealReviews(int MealID)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var mealReviews = await connection.QueryAsync<Review>("SELECT id, title, description, meal_id, created_date FROM reviews WHERE meal_id=@CustomId", new { CustomId = MealID });
        return mealReviews.ToList();
    }
}