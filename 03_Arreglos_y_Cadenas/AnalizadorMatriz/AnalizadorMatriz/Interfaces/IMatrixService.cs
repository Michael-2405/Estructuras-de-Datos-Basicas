using AnalizadorMatriz.Modelos;

namespace AnalizadorMatriz.Interfaces
{
  /// <summary>
  /// Define operaciones de análisis para una matriz.
  /// </summary>
  public interface IMatrixService
  {
    /// <summary>
    /// Carga la matriz que será analizada.
    /// </summary>
    /// <param name="matrix">Matriz a cargar.</param>
    void LoadMatrix(int[,] matrix);

    /// <summary>
    /// Obtiene el elemento con el valor máximo de la matriz.
    /// </summary>
    /// <returns>Objeto MatrixElement con información del valor máximo.</returns>
    MatrixElement GetMaxElement();

    /// <summary>
    /// Obtiene el elemento con el valor mínimo de la matriz.
    /// </summary>
    /// <returns>Objeto MatrixElement con información del valor mínimo.</returns>
    MatrixElement GetMinElement();
  }
}
