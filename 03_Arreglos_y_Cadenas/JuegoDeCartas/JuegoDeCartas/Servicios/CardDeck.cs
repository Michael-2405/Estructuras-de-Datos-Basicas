using JuegoDeCartas.Enums;
using JuegoDeCartas.Interfaces;
using JuegoDeCartas.Modelos;

namespace JuegoDeCartas.Servicios
{
  public class CardDeck : ICardDeck
  {
    private readonly List<Card> _cards;
    private readonly Random _random;

    public CardDeck()
    {
      _cards = new List<Card>();
      _random = new Random();
      InitializeDeck();
    }

    private void InitializeDeck()
    {
      foreach(Symbol suit in Enum.GetValues(typeof(Symbol)))
      {
        foreach(Value rank in Enum.GetValues(typeof(Value)))
        {
          _cards.Add(new Card(suit, rank));
        }
      }
    }

    public void Shuffle()
    {
      for(int i = _cards.Count - 1; i > 0; i--)
      {
        int j = _random.Next(i + 1);
        var temp = _cards[i];
        _cards[i] = _cards[j];
        _cards[j] = temp;
      }
    }

    public bool IsValid()
    {
      return _cards.Count == 52 && _cards.Distinct().Count() == 52;
    }

    public List<Card> Deal(int numberOfCards)
    {
      var hand = _cards.GetRange(0, Math.Min(numberOfCards, _cards.Count));
      _cards.RemoveRange(0, hand.Count);
      return hand;
    }
    public List<Card> GetAllCards()
    {
      return _cards;
    }
  }
}
