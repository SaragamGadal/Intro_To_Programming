




namespace Banking.Domain;
public class Account
{
    private decimal _currentBalance = 5000;
    public void Deposit(decimal amountToDeposit)
    {
        _currentBalance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        return _currentBalance; // JFHCI (BS)
    }

    public void Withdraw(decimal withdrawAmount)
    {
        _currentBalance -= withdrawAmount;
    }
}
