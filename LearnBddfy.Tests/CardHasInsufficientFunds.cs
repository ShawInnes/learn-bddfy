using FluentAssertions;
using TestStack.BDDfy;
using Xunit;
using LearnBddfy.Core;

namespace LearnBddfy.Tests
{
    /*
    Scenario 2: Account has insufficient funds
    Given the account balance is $10
      And the card is valid
      And the machine contains enough money
    When the Account Holder requests $20
    Then the ATM should not dispense any money
      And the ATM should say there are insufficient funds
      And the account balance should be $10
      And the card should be returned
     */
    public class CardHasInsufficientFunds
    {
        private Card _card;
        Atm _subject;

        void GivenTheAccountBalanceIs10()
        {
            _card = new Card(true, 10);
        }

        void AndGivenTheCardIsValid()
        {
        }

        void AndGivenTheMachineContainsEnoughMoney()
        {
            _subject = new Atm(100);
        }

        void WhenTheAccountHolderRequests20()
        {
            _subject.RequestMoney(_card, 20);
        }

        void ThenTheAtmShouldNotDispenseAnyMoney()
        {
            _subject.DispenseValue.Should().Be(0);
        }

        void AndTheAtmShouldSayThereAreInsufficientFunds()
        {
            _subject.Message.Should().Be(DisplayMessage.InsufficientFunds);
        }

        void AndTheAccountBalanceShouldBe10()
        {
            _card.AccountBalance.Should().Be(10);
        }

        void AndTheCardShouldBeReturned()
        {
            _subject.CardIsRetained.Should().BeFalse();
        }
    }
}
