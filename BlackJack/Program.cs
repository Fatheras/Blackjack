using System;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Player player = new Player();
            Player dealer = new Player("Dealer");
            CardDeck deck = new CardDeck();
            GameInfo game = new GameInfo(player, dealer, deck);
            Round round = new Round(game);
            IO inputoutput = new IO(round);
            inputoutput.InputName();
            inputoutput.StartGame();
            Console.Read();
        }
    }
}
