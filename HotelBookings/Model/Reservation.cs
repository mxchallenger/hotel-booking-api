namespace HotelBookings;

public class Reservation
{
    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? GuestEmail { get; set; }

    public int RoomTypeId { get; set; }

    public DateTime CheckInDate { get; set; }

    public int NumberOfNights { get; set; }
}

