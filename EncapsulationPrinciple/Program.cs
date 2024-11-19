namespace EncapsulationPrinciple;

class Program
{
    static void Main(string[] args)
    {
        #region Banck Account

        // // Starts with a balance of 500
        // BankAccount myAccount = new BankAccount(500);
        //
        // // Balance becomes 700
        // myAccount.Deposit(200); 
        // Console.WriteLine(myAccount.Balance); // Outputs: 700
        //
        // // Balance becomes 600
        // myAccount.Withdraw(100); 
        // Console.WriteLine(myAccount.Balance); // Outputs: 600
        //
        // // myAccount.balance = -1000;  // This would be an error, as the balance field is private and inaccessible directly.
        #endregion

        #region Coffee Machine

        // CoffeeMachine myMachine = new CoffeeMachine(1000, 100);  // Initialize with 1000 ml of water and 100 grams of beans
        //
        // // Abstraction with encapsulation
        // myMachine.MakeEspresso();  // Outputs: Heating water... Grinding coffee beans... Making Espresso...
        //
        // Console.WriteLine($"Beans left: {myMachine.BeansLeft()} grams");  // Outputs: Beans left: 80 grams

        #endregion

        #region Car

        // Car myCar = new Car();
        // This Applying Abstraction and Encapsulation
        // myCar.Drive();  // Outputs: Current speed: 8.4 m/s
        // myCar.Drive();  // Outputs: Current speed: 16.8 m/s
        #endregion

        #region Software System
        // var adminRole = new Role("Admin", [
        //     PermissionType.Read,
        //     PermissionType.Write,
        //     PermissionType.Delete
        // ]);
        //
        // var userRole = new Role("user", [
        //     PermissionType.Read,
        //     PermissionType.Write
        // ]);
        //
        // var Ahmad = new User("Ahmad", adminRole);
        // var Adam = new User("Adam", userRole);
        //
        // SystemManager manager = new SystemManager();
        // manager.AccessResources(Ahmad, PermissionType.Delete); // Outputs: Alice has Delete permission and can access the resource.
        // manager.AccessResources(Adam, PermissionType.Delete); // Outputs: Bob does not have Delete permission and cannot access the resource.

        #endregion

        #region Library Book
        LibraryBook book = new LibraryBook("Moby Dick", "1234567890");
        book.CheckOut(); // Outputs: Successfully checked out Moby Dick.
        book.CheckOut(); // Outputs: Moby Dick is already checked out.
        book.ReturnBook(); // Outputs: Successfully returned Moby Dick.
        

        #endregion
        Console.Read();
    }
}