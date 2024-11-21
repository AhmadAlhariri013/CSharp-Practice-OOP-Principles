namespace AbstractionPrinciple.PaymentProcessing;
//Concrete Implementations
//Implement the interface for each payment method
public class PayPalPayment:IPaymentMethod
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
        // Logic to process PayPal payment
        return true;
    }
}