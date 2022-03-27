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

    public IEnumerable<Reservation> ListReservations()
    {
        return Reservations;
    }
    public void Add(Reservation r)
    {
        Reservations.Add(r);
    }
    public IEnumerable<Reservation> GetReservation(int id)
    {
        return Reservations.Where(r => r.ID == id);
    }

    public IEnumerable<Reservation> MealReservations(int id)
    {
        return Reservations.Where(r => r.MealID == id);
    }
}