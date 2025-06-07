namespace AnalizadorMatriz.Interfaces
{
  /// <summary>
  /// Define operaciones para entrada y salida de datos de una matriz.
  /// </summary>
  public interface IMatrixIO
  {
    /// <summary>
    /// Solicita al usuario las dimensiones (filas y columnas) de la matriz.
    /// </summary>
    /// <returns>Tupla con número de filas y columnas.</returns>
    (int Rows, int Columns) GetMatrixDimensions();

    /// <summary>
    /// Solicita los valores de cada elemento de la matriz.
    /// </summary>
    /// <param name="rows">Número de filas.</param>
    /// <param name="columns">Número de columnas.</param>
    /// <returns>Matriz llena con los valores ingresados.</returns>
    int[,] GetMatrixValues(int rows, int columns);

    /// <summary>
    /// Muestra la matriz completa en consola.
    /// </summary>
    /// <param name="matrix">Matriz a mostrar.</param>
    void ShowMatrix(int[,] matrix);

    /// <summary>
    /// Muestra un elemento específico de la matriz con una etiqueta.
    /// </summary>
    /// <param name="label">Etiqueta descriptiva (ej. "Máximo").</param>
    /// <param name="value">Valor del elemento.</param>
    /// <param name="row">Fila del elemento.</param>
    /// <param name="column">Columna del elemento.</param>
    void ShowElement(string label, int value, int row, int column);
  }
}
