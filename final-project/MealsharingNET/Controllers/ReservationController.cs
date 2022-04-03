using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("Reservations")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public async Task<List<Reservation>> ListAllReservations()
    {
        return await _repo.ListReservations();
    }
    [HttpPost("Add")]
    public async Task AddReservation([FromBody] Reservation r)
    {
        await _repo.Add(r);
    }

    [HttpGet("GetMealReservations")]
    public async Task<List<Reservation>> MealReservations(int id)
    {
        return await _repo.MealReservations(id);
    }
} 