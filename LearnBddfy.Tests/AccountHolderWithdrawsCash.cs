using TestStack.BDDfy;
using Xunit;

namespace LearnBddfy.Tests
{
    [Story(
        AsA = "As an Account Holder",
        IWant = "I want to withdraw cash from an ATM",
        SoThat = "So that I can get money when the bank is closed")]
    public class AccountHolderWithdrawsCash
    {
        [Fact]
        void CardHasBeenDisabled()
        {
            new CardHasBeenDisabled().BDDfy();
        }

        [Fact]
        void CardHasSufficientFunds()
        {
            new CardHasSufficientFunds().BDDfy();
        }

        [Fact]
        void CardHasInsufficientFunds()
        {
            new CardHasInsufficientFunds().BDDfy();
        }

    }
}
