using MealsharingNET.Models;

namespace MealsharingNET;

public class InMemoryReservationRepository : IReservationRepository
{
    private List<Reservation> Reservations { get; set; } = new List<Reservation>(){
        new Reservation()
        {
            ID=1,
            NumberOfGuests=6,
            MealID=2,
            ContactNumber= "11111111",
            Name= "Hanie",
            Email="hanie@gmail.com"
        },
        new Reservation()
        {
            ID=2,
            NumberOfGuests=2,
            MealID=1,
            ContactNumber= "2222222",
            Name= "Reza",
            Email="reza@gmail.com"
        }
    };

    public async Task<List<Reservation>> ListReservations()
    {
      return await Task.FromResult(Reservations);
    }
    public void Add(Reservation r)
    {
        Reservations.Add(r);
    }

    public Task<List<Reservation>> MealReservations(int id)
    {
        var mealReservations = Reservations.Where(reservation => reservation.MealID == id).ToList();
        return Task.FromResult(mealReservations);
    }
}