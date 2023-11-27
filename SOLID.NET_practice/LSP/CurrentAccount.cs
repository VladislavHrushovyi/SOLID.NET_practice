using SOLID.NET_practice.S;

namespace SOLID.NET_practice.LSP;

public class CurrentAccount(string accountIdentifier, decimal balance, decimal overdraftLimit) 
    : BaseBankAccount(accountIdentifier, balance)
{
    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance + overdraftLimit)
        {
            Balance -= amount;
            Logger.Log(base.ToString() + $", \nWithdraw: {amount}", LoggingType.Info);
        }
        else
        {
            Logger.Log(base.ToString() + $"\nExceeded Overdraft Limit.", LoggingType.Error);
        }
    }
}