namespace LearnBddfy.Core
{
    public class Card
    {
        public bool CardEnabled { get; }
        public int AccountBalance { get; set; }

        public Card(bool cardEnabled, int accountBalance)
        {
            CardEnabled = cardEnabled;
            AccountBalance = accountBalance;
        }
    }
}
