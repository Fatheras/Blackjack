namespace BlackJack
{
    class GameInfo
    {
        private Player _player;
        private Player _dealer;
        private CardDeck _gameDeck;

        internal Player Player { get => _player; }
        internal Player Dealer { get => _dealer; }
        internal CardDeck GameDeck { get => _gameDeck; }
        public GameInfo(Player player, Player dealer, CardDeck gameDeck)
        {
            _player = player;
            _dealer = dealer;
            _gameDeck = gameDeck;
        }
    }
}
