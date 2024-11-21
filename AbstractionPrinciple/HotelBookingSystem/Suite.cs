namespace AbstractionPrinciple.HotelBookingSystem;
//Concrete Implementations
//Implement the interface for each room type
public class Suite : IRoom
{
    public decimal Rate => 500.00M;
    public int Capacity => 6;
    public string Description => "Luxurious suite with top-notch amenities.";
    public void DisplayRoomDetails()
    {
        Console.WriteLine($"Type: Suite | Rate: {Rate:C} | Capacity: {Capacity} | Description: {Description}");
    }
}