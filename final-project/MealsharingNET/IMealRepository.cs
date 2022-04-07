using System.Collections.Generic;
using MealsharingNET.Models;

namespace MealsharingNET;

public interface IMealRepository
{
    Task<List<Meal>> ListMeals();
    Task Add(Meal m);

    Task<Meal> GetMeal(int id);
    Task DeleteMeal(int id);
}