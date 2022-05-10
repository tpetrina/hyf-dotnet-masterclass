using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("api/meals")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("")]
    public async Task<List<Meal>> ListAllMeals()
    {
        return await _repo.ListMeals();
    }
    [HttpPost("")]
    public async Task AddMeal([FromBody] Meal m)
    {
       await _repo.Add(m);
    }

    [HttpGet("{id}")]
    public async Task<IEnumerable<Meal>> GetMeal(int id)
    {
        var meal = await _repo.GetMeal(id);
        return  new[] { meal };
    }

    [HttpDelete("{id}")]
    public async Task DeleteMeal(int id)
    {
        await _repo.DeleteMeal(id);
    }
}