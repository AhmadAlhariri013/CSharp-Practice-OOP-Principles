namespace AbstractionPrinciple.PaymentProcessing;

public class CheckoutSystem
{
    public void Checkout(IPaymentMethod paymentMethod, decimal amount)
    {
        if (paymentMethod.ProcessPayment(amount))
        {
            Console.WriteLine("Payment successful!");
        }
        else
        {
            Console.WriteLine("Payment failed.");
        }
    }
}