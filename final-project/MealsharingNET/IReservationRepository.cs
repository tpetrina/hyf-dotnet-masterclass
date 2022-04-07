using MealsharingNET.Models;

namespace MealsharingNET;

public interface IReservationRepository
{
    Task<List<Reservation>> ListReservations();
    Task Add(Reservation r);
    Task<List<Reservation>> MealReservations(int id);
    Task DeleteReservation(int id);
} 