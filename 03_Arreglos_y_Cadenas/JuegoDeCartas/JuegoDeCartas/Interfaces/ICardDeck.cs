using JuegoDeCartas.Modelos;

namespace JuegoDeCartas.Interfaces
{
  /// <summary>
  /// Define la interfaz para una baraja de cartas.
  /// </summary>
  public interface ICardDeck
  {
    /// <summary>
    /// Mezcla las cartas de la baraja.
    /// </summary>
    void Shuffle();

    /// <summary>
    /// Reparte una cantidad de cartas especificada.
    /// </summary>
    /// <param name="numberOfCards">Cantidad de cartas a repartir.</param>
    /// <returns>Lista de cartas repartidas.</returns>
    List<Card> Deal(int numberOfCards);

    /// <summary>
    /// Devuelve todas las cartas restantes de la baraja.
    /// </summary>
    List<Card> GetAllCards();

    /// <summary>
    /// Valida que la baraja tenga exactamente 52 cartas únicas.
    /// </summary>
    /// <returns>True si es válida; de lo contrario, false.</returns>
    bool IsValid();
  }
}
