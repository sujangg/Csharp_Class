namespace G;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal intialBalance)
    {
        balance = intialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }
}

public void Withdrawn(decimal amount)
{
    if(balance >= amount)
    {
        balance -= amount;
    }
    else
    {
        Console.WriteLine("Insufficient Funds.")
    };
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
