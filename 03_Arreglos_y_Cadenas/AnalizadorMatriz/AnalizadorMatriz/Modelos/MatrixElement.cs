namespace AnalizadorMatriz.Modelos
{
  /// <summary>
  /// Representa un elemento individual de una matriz.
  /// Contiene su valor y posición.
  /// </summary>
  public class MatrixElement
  {
    /// <summary>
    /// Valor numérico del elemento.
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// Fila en la que se encuentra el elemento.
    /// </summary>
    public int Row { get; set; }

    /// <summary>
    /// Columna en la que se encuentra el elemento.
    /// </summary>
    public int Column { get; set; }

    public override string ToString()
    {
      return $"Valor: {Value} en posicion [{Row}, {Column}]";
    }
  }
}
