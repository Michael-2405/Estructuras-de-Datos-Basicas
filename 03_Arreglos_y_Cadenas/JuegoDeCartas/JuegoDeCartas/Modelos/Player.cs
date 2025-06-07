namespace JuegoDeCartas.Modelos
{
  public class Player
  {
    public int Number { get; }
    public List<Card> Hand { get; }

    public Player(int number)
    {
      Number = number;
      Hand = new List<Card>();
    }

    public void AddCards(List<Card> cards)
    {
      Hand.AddRange(cards);
    }

    public void ShowHand()
    {
      Console.WriteLine();
      Console.WriteLine($"Mano del jugador {Number}");
      foreach(var cart in Hand)
      {
        Console.WriteLine($"  - {cart}");
      }
      Console.WriteLine();
    }
  }
}
