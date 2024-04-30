using System;

class Account
{
    private double balance;

    // Constructor with no arguments
    public Account()
    {
        balance = 0; // Default balance
    }

    // Constructor with two arguments
    public Account(double initialBalance)
    {
        balance = initialBalance;
    }

    // Method to deposit balance
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited " + amount + " successfully.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Amount must be greater than 0.");
        }
    }

    // Method to withdraw balance
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn " + amount + " successfully.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount. Amount must be greater than 0.");
        }
    }

    // Method to get current balance
    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an account with no initial balance
        Account account = new Account();

        // Prompt user for initial deposit
        Console.Write("Enter initial deposit amount: ");
        double initialDeposit = Convert.ToDouble(Console.ReadLine());
        account.Deposit(initialDeposit);

        // Loop for deposit and withdrawal operations
        while (true)
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter deposit amount: ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                case 2:
                    Console.Write("\nEnter withdrawal amount: ");
                    double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                    account.Withdraw(withdrawalAmount);
                    break;
                case 3:
                    Console.WriteLine("\nCurrent balance: " + account.GetBalance());
                    break;
                case 4:
                    Console.WriteLine("\nExiting program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }
        }
    }
}
