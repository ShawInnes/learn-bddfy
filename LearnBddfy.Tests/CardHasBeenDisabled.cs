using System;
using FluentAssertions;
using LearnBddfy.Core;
using TestStack.BDDfy;
using Xunit;

namespace LearnBddfy.Tests
{
    /*
      Scenario 3: Card has been disabled
      Given the card is disabled
      When the Account Holder requests $20
      Then the ATM should retain the card
        And the ATM should say the card has been retained
     */
    public class CardHasBeenDisabled
    {
        private Card _card;
        Atm _subject;

        void GivenTheCardIsDisabled()
        {
            _card = new Card(false, 100);
            _subject = new Atm(100);
        }

        void WhenTheAccountHolderRequestsMoney()
        {
            _subject.RequestMoney(_card, 20);
        }

        void ThenTheAtmShouldRetainTheCard()
        {
            _subject.CardIsRetained.Should().BeTrue();
        }

        void AndTheAtmShouldSayTheCardHasBeenRetained()
        {
            _subject.Message.Should().Be(DisplayMessage.CardIsRetained);
        }
    }
}
