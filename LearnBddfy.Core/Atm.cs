namespace LearnBddfy.Core
{
    public class Atm
    {
        public int MachineBalance { get; private set; }
        public bool CardIsRetained { get; private set; }
        public DisplayMessage Message { get; private set; }

        public Atm(int machineBalance)
        {
            MachineBalance = machineBalance;
        }

        public void RequestMoney(Card card, int amount)
        {
            if (!card.CardEnabled)
            {
                CardIsRetained = true;
                Message = DisplayMessage.CardIsRetained;
            }
        }
    }
}
