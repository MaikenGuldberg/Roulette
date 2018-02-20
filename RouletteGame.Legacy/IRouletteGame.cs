namespace RouletteGame.Legacy
{
    public interface IRouletteGame
    {
        void CloseBets();
        void OpenBets();
        void PayUp();
        void PlaceBet(Bet bet);
        void SpinRoulette();
    }
}