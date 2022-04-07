namespace mealsharingNET;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using MealsharingNET;
using MealsharingNET.Models;
using MySql.Data.MySqlClient;

public class ReservationRepository : IReservationRepository
{
   public async Task Add(Reservation r)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservationID = await connection.ExecuteAsync("INSERT INTO reservations (meal_id, created_date, contact_phonenumber, contact_name, contact_email, number_of_guests ) VALUES (@MealID, @CreatedDate, @ContactNumber, @Name, @Email, @NumberOfGuests)", r);
    }

    public async Task<List<Reservation>> ListReservations()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservations = await connection.QueryAsync<Reservation>("SELECT id, meal_id as MealID, created_date as CreatedDate, contact_phonenumber as ContactNumber, contact_name as Name, contact_email as Email, number_of_guests as NumberOfGuests FROM reservations");
        return reservations.ToList();
    }

    public async Task<Reservation> GetReservation(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var reservation = await connection.QueryFirstAsync<Reservation>("SELECT id, meal_id as MealID, created_date as CreatedDate, contact_phonenumber as ContactNumber, contact_name as Name, contact_email as Email, number_of_guests as NumberOfGuests FROM reservations WHERE id=@CustomId", new { CustomId = id });
        return reservation;
    }

    public async Task<List<Reservation>> MealReservations(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var mealReservations = await connection.QueryAsync<Reservation>("SELECT id, meal_id as MealID, created_date as CreatedDate, contact_phonenumber as ContactNumber, contact_name as Name, contact_email as Email, number_of_guests as NumberOfGuests FROM reservations WHERE meal_id=@CustomId", new { CustomId = id });
        return mealReservations.ToList();
    }

    public async Task DeleteReservation(int id)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        await connection.ExecuteAsync(@"DELETE FROM reservations WHERE Id = @Id", new { Id = id });
    }
}