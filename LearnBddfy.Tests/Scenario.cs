namespace LearnBddfy.Tests
{
    /*
     Story: Account Holder withdraws cash

     As an Account Holder
     I want to withdraw cash from an ATM
     So that I can get money when the bank is closed

     Scenario 1: Account has sufficient funds
     Given the account balance is $100
       And the card is valid
       And the machine contains enough money
     When the Account Holder requests $20
     Then the ATM should dispense $20
       And the account balance should be $80
      And the card should be returned

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

    public class Scenario
    {
    }
}
