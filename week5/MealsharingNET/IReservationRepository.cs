using MealsharingNET.Models;

namespace MealsharingNET;

public interface IReservationRepository
{
    Task<List<Reservation>> ListReservations();
    void Add(Reservation r);
    Task<List<Reservation>> MealReservations(int id);
} 