namespace HotelBookings;

public class Room
{
    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public string? RoomName { get; set; }

    public string? RoomDescription { get; set; }

    public decimal RoomRate { get; set; }

}
