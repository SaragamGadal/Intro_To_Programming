using Banking.Domain;

namespace Banking.Tests.Accounts;
public class MakingDeposits
{
    [Fact]
    public void DepositingIncreasesBalance()
    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100.25M;
        // When

        account.Deposit(amountToDeposit);

        // Then
        var newBalance = account.GetBalance();
        Assert.Equal(openingBalance + amountToDeposit, newBalance);


    }
}