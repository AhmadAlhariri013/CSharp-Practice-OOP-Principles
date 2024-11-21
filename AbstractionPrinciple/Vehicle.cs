namespace AbstractionPrinciple;

/*
 * Suppose you want to model a basic vehicle system.
 * All vehicles can be started and stopped, but the underlying details of how this happens can differ for each vehicle type.
 */

//Abstract Base Class (Abstraction)
public abstract class Vehicle
{
    // These are abstract methods; the derived classes will provide the implementation.
    public abstract void Start();
    public abstract void Stop();
}

//Concrete Implementations
public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting with a key turn.");
    }
    public override void Stop()
    {
        Console.WriteLine("Car is stopping using its brakes.");
    }
}

public class ElectricTrain : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Electric train is starting by powering up.");
    }
    public override void Stop()
    {
        Console.WriteLine("Electric train is stopping by cutting off the power.");
    }
}