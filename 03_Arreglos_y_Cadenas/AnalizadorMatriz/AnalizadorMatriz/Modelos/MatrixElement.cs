namespace AnalizadorMatriz.Modelos
{
  public class MatrixElement
  {
    public int Value { get; set; }
    public int Row {  get; set; }
    public int Column { get; set; }

    public override string ToString()
    {
      return $"Valor: {Value} en posicion [{Row}, {Column}]";
    }
  }
}
