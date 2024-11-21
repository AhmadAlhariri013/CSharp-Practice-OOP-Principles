namespace AbstractionPrinciple.HotelBookingSystem;

/*
 * Imagine a hotel booking system where guests can book various rooms, such as a standard, deluxe, or suite.
 * Each room type can have different rates, amenities, and capacities.
 * Instead of having separate methods to handle each room type, we’ll use abstraction to simplify the management of these rooms.
 */


//Abstraction Layer
//Define an abstract class or interface that encapsulates the common behavior of all room types
public interface IRoom
{
    decimal Rate { get; }
    int Capacity { get; }
    string Description { get; }
    void DisplayRoomDetails();
}

