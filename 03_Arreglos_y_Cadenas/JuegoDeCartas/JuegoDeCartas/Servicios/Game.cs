using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Modelos;

namespace JuegoDeCartas.Servicios
{
  public class Game
  {
    private readonly ICardDeck _cardDeck;
    private readonly List<Player> _players;
    private const int CardPerPlayers = 5;

    public Game(ICardDeck cardDeck)
    {
      _cardDeck = cardDeck;
      _players = new List<Player>();
    }

    public async Task StartAsync()
    {
      Console.WriteLine(" === Juego de cartas - 3 y 2 ===");

      if (!_cardDeck.IsValid())
      {
        Console.WriteLine(" Error. La baraja no tiene 52 cartas");
        return;
      }

      _cardDeck.Shuffle();

      int amountPlayers = InputHelper.ReadPositiveInt("Cuantas personas jugaran? ");
      int neededCards = amountPlayers * CardPerPlayers;

      if(neededCards > _cardDeck.GetAllCards().Count)
      {
        Console.WriteLine($"No hay cartas suficientes para todos. Solo hay {_cardDeck.GetAllCards().Count} disponibles");
        return;
      } 

      for (int i = 1; i <= amountPlayers; i++)
      {
        var player = new Player(i);
        Console.WriteLine($"\n Repartiendo a jugador {i}...");
        await Task.Delay(2000);

        for(int j = 0; j < CardPerPlayers; j++)
        {
          var card = _cardDeck.Deal(1).First();
          player.AddCards(new List<Card> { card });
          Console.WriteLine($" -> Carta Recibida: {card}");
          await Task.Delay(1000);
        }

        _players.Add(player);
      }

      ShowResults();
    }

    public void ShowResults()
    {
      foreach (var player in _players)
      {
        player.ShowHand(); ;
      }

      Console.WriteLine("Reparto de cartas completado");
    }
  }
}
