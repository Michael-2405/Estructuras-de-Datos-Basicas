using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Servicios;

/// <summary>
/// Punto de entrada del programa.
/// </summary>
class Program
{
  /// <summary>
  /// Método principal del juego de cartas.
  /// </summary>
  public static async Task Main(string[] args)
  {
    ICardDeck cardDeck = new CardDeck();
    var game = new Game(cardDeck);
    await game.StartAsync();
  }
}