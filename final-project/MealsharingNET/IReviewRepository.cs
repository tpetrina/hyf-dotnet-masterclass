using System.Collections.Generic;
using MealsharingNET.Models;

namespace MealsharingNET;

public interface IReviewRepository
{
    Task<List<Review>> ListReviews();
    Task Add(Review review);
    Task<List<Review>> MealReviews(int MealID);
}