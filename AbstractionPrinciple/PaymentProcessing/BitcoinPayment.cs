namespace AbstractionPrinciple.PaymentProcessing;

public class BitcoinPayment : IPaymentMethod
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Bitcoin payment of {amount:C}");
        // Logic to process Bitcoin payment
        return true;
    }
}

//Using the Abstraction
//With the abstraction in place, the checkout process becomes simplified