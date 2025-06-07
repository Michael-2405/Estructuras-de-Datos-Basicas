using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Servicios;

class Program
{
  public static async Task Main(string[] args)
  {
    ICardDeck cardDeck = new CardDeck();
    var game = new Game(cardDeck);
    await game.StartAsync();

  }
}
