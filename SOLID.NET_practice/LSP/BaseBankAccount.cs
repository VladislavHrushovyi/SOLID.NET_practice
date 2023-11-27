using SOLID.NET_practice.S;

namespace SOLID.NET_practice.LSP;

public class BaseBankAccount(string accountIdentifier, decimal balance)
{
    public string AccountIdentifier { get; set; } = accountIdentifier;
    public decimal Balance { get; set; } = balance;

    protected readonly ILogger Logger = new ConsoleLogger();

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
        Logger.Log(this + $", Deposit: {amount}", LoggingType.Info);
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Logger.Log(this + $", Withdraw: {amount}", LoggingType.Info);
        }
        else
        {
            Logger.Log($"Insufficient balance. \n {this}, Withdrawing: {amount}", LoggingType.Error);
        }
    }

    public override string ToString()
    {
        return $"AccountNumber: {AccountIdentifier}, Balance: {Balance}";
    }
}