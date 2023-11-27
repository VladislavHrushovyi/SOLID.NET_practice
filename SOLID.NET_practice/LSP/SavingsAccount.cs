using SOLID.NET_practice.S;

namespace SOLID.NET_practice.LSP;

public class SavingsAccount(string accountIdentifier, decimal balance, decimal interestRate)
    : BaseBankAccount(accountIdentifier, balance)
{
    private readonly decimal InterestRate = interestRate;

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Logger.Log(base.ToString() + $", Withdraw: {amount}", LoggingType.Info);
        }
        else
        {
            Logger.Log($"Insufficient balance. \n " +
                       $"{base.ToString()}, Withdrawing: {amount},\n" +
                       $"Insufficient Funds, Available Funds: {Balance}", LoggingType.Error);
        }
    }
}