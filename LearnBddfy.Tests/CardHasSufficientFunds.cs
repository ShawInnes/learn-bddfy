using FluentAssertions;
using TestStack.BDDfy;
using Xunit;
using LearnBddfy.Core;

namespace LearnBddfy.Tests
{
    /*
     Scenario 1: Account has sufficient funds
     Given the account balance is $100
       And the card is valid
       And the machine contains enough money
     When the Account Holder requests $20
     Then the ATM should dispense $20
       And the account balance should be $80
      And the card should be returned
     */
    public class CardHasSufficientFunds
    {
        private Card _card;
        Atm _subject;

        void GivenTheAccountBalanceIs100()
        {
            _card = new Card(true, 100);
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

        void ThenTheAtmShouldDispense20()
        {
            _subject.DispenseValue.Should().Be(20);
        }

        void AndTheAccountBalanceShouldBe80()
        {
            _card.AccountBalance.Should().Be(80);
        }

        void AndTheCardShouldBeReturned()
        {
            _subject.CardIsRetained.Should().BeFalse();
        }
    }
}
