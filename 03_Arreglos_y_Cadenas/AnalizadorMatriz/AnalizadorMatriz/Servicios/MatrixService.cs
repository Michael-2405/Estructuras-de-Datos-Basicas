using AnalizadorMatriz.Interfaces;
using AnalizadorMatriz.Modelos;

namespace AnalizadorMatriz.Servicios
{
  public class MatrixService : IMatrixService
  {
    private int[,] _matrix;

    public void LoadMatrix(int[,] matrix)
    {
      _matrix = matrix;
    }

    public MatrixElement GetMaxElement()
    {
      MatrixElement element = new MatrixElement { Value = _matrix[0, 0], Row = 0, Column = 0 };

      for (int i = 0; i < _matrix.GetLength(0); i++)
      {
        for (int j = 0; j < _matrix.GetLength(1); j++)
        {
          if (_matrix[i, j] > element.Value)
          {
            element.Value = _matrix[i, j];
            element.Row = i;
            element.Column = j;
          }
        }
      }
      return element;
    }

    public MatrixElement GetMinElement()
    {
      MatrixElement element = new MatrixElement { Value = _matrix[0, 0], Row = 0, Column = 0 };

      for (int i = 0; i < _matrix.GetLength(0); i++)
      {
        for (int j = 0; j < _matrix.GetLength(1); j++)
        {
          if (_matrix[i, j] < element.Value)
          {
            element.Value = _matrix[i, j];
            element.Row = i;
            element.Column = j;
          }
        }
      }
      return element;
    }
  }
}
