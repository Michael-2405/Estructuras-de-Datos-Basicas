using JuegoDeCartas.Enums;

namespace JuegoDeCartas.Modelos
{
  public class Card
  {
    public Symbol Symbol { get; }
    public Value Value { get; }

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
