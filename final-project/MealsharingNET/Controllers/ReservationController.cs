using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("api/revisions")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("")]
    public async Task<List<Reservation>> ListAllReservations()
    {
        return await _repo.ListReservations();
    }
    [HttpPost("")]
    public async Task AddReservation([FromBody] Reservation r)
    {
        await _repo.Add(r);
    }

    [HttpGet("{id}")]
    public async Task<List<Reservation>> MealReservations(int id)
    {
        return await _repo.MealReservations(id);
    }

    [HttpDelete("{id}")]
    public async Task DeleteReservation(int id)
    {
        await _repo.DeleteReservation(id);
    }
} 