namespace AbstractionPrinciple.MessagingPlatforms;

//Concrete Implementations
//Now, we'll create concrete classes that implement this interface.
public class EmailService : IMessagingService
{
    public void SendMessage(string recipient, string message)
    {
        Console.WriteLine($"Sending Email to {recipient}: {message}");
        // Here, you'd have the actual logic to send an email.
    }
}