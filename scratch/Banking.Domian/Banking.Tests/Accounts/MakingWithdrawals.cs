using Banking.Domain;

namespace Banking.Tests.Accounts;
public class MakingWithdrawals
{
    [Fact]
    public void WithdrawalsDecreasesBalance()
    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToWithDraw = 50.25M;

        account.Withdraw(amountToWithDraw);

        var newBalance = account.GetBalance();
        Assert.Equal(openingBalance - amountToWithDraw, newBalance);
    }
}
