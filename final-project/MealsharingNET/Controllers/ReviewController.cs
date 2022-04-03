using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("Reviews")]
public class ReviewController : ControllerBase
{
    private IReviewRepository _repo;

    public ReviewController(IReviewRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public async Task<List<Review>> ListAllReviews()
    {
        return await _repo.ListReviews();
    }
    
    [HttpPost("Add")]
    public async Task AddReview([FromBody] Review review)
    {
        await _repo.Add(review);
    }

    [HttpGet("GetMealReviews")]
    public async Task<List<Review>> MealReviews(int id)
    {
        return await _repo.MealReviews(id);
    }
} 