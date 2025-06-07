using JuegoDeCartas.Modelos;

namespace JuegoDeCartas.Interfaces
{
  public interface ICardDeck
  {
    void Shuffle();
    List<Card> Deal(int numberOfCards);
    List<Card> GetAllCards();
    public bool IsValid();
  }
}
