using AnalizadorMatriz.Interfaces;
using AnalizadorMatriz.Servicios;

class Program
{
  /// <summary>
  /// Punto de entrada del programa.
  /// Ejecuta el flujo principal para analizar una matriz.
  /// </summary>
  public static void Main()
  {
    IMatrixIO io = new MatrixIO();
    IMatrixService service = new MatrixService();

    Console.WriteLine(" === Analisis de la Matriz === ");

    // Paso 1: Obtener dimensiones
    var (rows, cols) = io.GetMatrixDimensions();

    // Paso 2: Cargar valores
    var matrix = io.GetMatrixValues(rows, cols);
    service.LoadMatrix(matrix);

    // Paso 3: Mostrar matriz
    io.ShowMatrix(matrix);

    // Paso 4: Obtener y mostrar resultados
    var max = service.GetMaxElement();
    var min = service.GetMinElement();

    io.ShowElement("Maximo", max.Value, max.Row, max.Column);
    io.ShowElement("Minimo", min.Value, min.Row, min.Column);
  }
}