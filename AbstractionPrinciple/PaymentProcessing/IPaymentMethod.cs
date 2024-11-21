namespace AbstractionPrinciple.PaymentProcessing;
/*
 * Let’s imagine a scenario where you’re developing a system for an online store that supports multiple payment methods
 * like Credit Cards, PayPal, and Bitcoin.
 * Without abstraction, you’d potentially have disparate methods like ProcessCreditCardPayment(), ProcessPayPalPayment(), etc.
 * This would make the system rigid and difficult to extend if you were to introduce new payment methods.
 */
//Abstraction Layer
//Define an interface representing any payment method
public interface IPaymentMethod
{
 bool ProcessPayment(decimal amount);
}