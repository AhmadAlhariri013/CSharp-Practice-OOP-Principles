namespace AbstractionPrinciple.HotelBookingSystem;
//Concrete Implementations
//Implement the interface for each room type
public class DeluxeRoom : IRoom
{
    public decimal Rate => 200.00M;
    public int Capacity => 4;
    public string Description => "Deluxe Room with premium amenities.";
    public void DisplayRoomDetails()
    {
        Console.WriteLine($"Type: Deluxe Room | Rate: {Rate:C} | Capacity: {Capacity} | Description: {Description}");
    }
}