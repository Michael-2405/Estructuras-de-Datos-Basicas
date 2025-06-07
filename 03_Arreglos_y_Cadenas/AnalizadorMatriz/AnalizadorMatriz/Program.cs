using AnalizadorMatriz.Interfaces;
using AnalizadorMatriz.Modelos;
using AnalizadorMatriz.Servicios;

class Program
{
  public static void Main()
  {
    IMatrixIO io = new MatrixIO();
    IMatrixService service = new MatrixService();

    Console.WriteLine(" === Analisis de la Matriz === ");
    var (rows, cols) = io.GetMatrixDimensions();

    var matrix = io.GetMatrixValues(rows, cols);
    service.LoadMatrix(matrix);

    io.ShowMatrix(matrix);

    var max = service.GetMaxElement();
    var min = service.GetMinElement();

    io.ShowElement("Maximo", max.Value, max.Row, max.Column);
    io.ShowElement("Minimo", min.Value, min.Row, min.Column);
  } 
}