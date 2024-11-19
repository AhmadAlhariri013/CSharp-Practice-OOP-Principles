namespace EncapsulationPrinciple;
/*
 * a bank customer can deposit or withdraw money from their account. 
 * certain rules and validations are applied,
 * such as ensuring that the balance does not go below a minimum limit
 * or the customer can’t withdraw more than what they have in the account.
 */
public class BankAccount
{
    #region first approach

    // This private field is encapsulated and can't be directly accessed from outside the class.
    private decimal balance; 
    public decimal Balance // same to: public decimal Balance => balance;
    {
        // Only provides a way to read the balance but not modify it directly.
        get { return balance; } 
    }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative");
        }
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount cannot be negative");
        }
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount cannot be negative");
        }

        if (balance - amount < 0)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        
        balance -= amount;
    }
    

    #endregion

}