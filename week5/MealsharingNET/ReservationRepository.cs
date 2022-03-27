namespace mealsharingNET;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using MealsharingNET;
using MealsharingNET.Models;
using MySql.Data.MySqlClient;

public class ReservationRepository : IReservationRepository
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
    
    public void Add(Reservation r)
    {
        Reservations.Add(r);
    }

    public Task<Reservation> GetReservation(int id)
    {
        var reservation = Reservations.FirstOrDefault(reservation=>reservation.ID == id);
        return Task.FromResult(reservation);
    }

    public Task<List<Reservation>> ListReservations()
    {
        return Task.FromResult(Reservations);
    }

    public async Task<List<Reservation>> MealReservations(int id)
    {
        var mealReservations = Reservations.Where(reservation => reservation.MealID == id).ToList();
        return await Task.FromResult(mealReservations);
    }
}