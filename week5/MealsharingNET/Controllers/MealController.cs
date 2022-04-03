using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("meals")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public async Task<List<Meal>> ListAllMeals()
    {
        return await _repo.ListMeals();
    }
    [HttpPost("Add")]
    public async Task AddMeal([FromBody] Meal m)
    {
       await _repo.Add(m);
    }

    [HttpGet("GetMeal")]
    public async Task<Meal> GetMeal(int id)
    {
        return await _repo.GetMeal(id);
    }
}