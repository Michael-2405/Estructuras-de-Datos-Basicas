using JuegoDeCartas.Enums;

namespace JuegoDeCartas.Modelos
{
  /// <summary>
  /// Representa una carta del mazo.
  /// </summary>
  public class Card
  {
    /// <summary>
    /// Palo de la carta.
    /// </summary>
    public Symbol Symbol { get; }

    /// <summary>
    /// Valor de la carta.
    /// </summary>
    public Value Value { get; }

    /// <summary>
    /// Crea una nueva carta.
    /// </summary>
    /// <param name="symbol">Palo de la carta.</param>
    /// <param name="value">Valor de la carta.</param>
    public Card(Symbol symbol, Value value)
    {
      Symbol = symbol;
      Value = value;
    }

    public override bool Equals(object? obj)
    {
      return obj is Card other && Symbol == other.Symbol && Value == other.Value;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(Symbol, Value);
    }

    public override string ToString() => $"{Value} de {Symbol}";
  }
}
}
