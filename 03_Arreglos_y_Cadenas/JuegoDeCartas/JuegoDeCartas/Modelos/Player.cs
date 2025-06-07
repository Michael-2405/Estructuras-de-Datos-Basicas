namespace JuegoDeCartas.Modelos
{
  /// <summary>
  /// Representa a un jugador en el juego.
  /// </summary>
  public class Player
  {
    /// <summary>
    /// Número identificador del jugador.
    /// </summary>
    public int Number { get; }

    /// <summary>
    /// Lista de cartas que tiene el jugador.
    /// </summary>
    public List<Card> Hand { get; }

    /// <summary>
    /// Crea un nuevo jugador.
    /// </summary>
    /// <param name="number">Número del jugador.</param>
    public Player(int number)
    {
      Number = number;
      Hand = new List<Card>();
    }

    /// <summary>
    /// Agrega una lista de cartas a la mano del jugador.
    /// </summary>
    /// <param name="cards">Cartas a agregar.</param>
    public void AddCards(List<Card> cards)
    {
      Hand.AddRange(cards);
    }

    /// <summary>
    /// Muestra las cartas del jugador en consola.
    /// </summary>
    public void ShowHand()
    {
      Console.WriteLine();
      Console.WriteLine($"Mano del jugador {Number}");
      foreach (var card in Hand)
      {
        Console.WriteLine($"  - {card}");
      }
      Console.WriteLine();
    }
  }
}
