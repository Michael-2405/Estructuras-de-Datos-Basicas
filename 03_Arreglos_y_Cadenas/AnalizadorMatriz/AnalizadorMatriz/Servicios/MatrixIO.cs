using AnalizadorMatriz.Interfaces;

namespace AnalizadorMatriz.Servicios
{
  public class MatrixIO : IMatrixIO
  {
    public (int Rows, int Columns) GetMatrixDimensions()
    {
      Console.Write("Ingrese el numero de filas: ");
      int rows = int.Parse(Console.ReadLine()!);

      Console.Write("Ingrese el numero de columnas: ");
      int cols = int.Parse(Console.ReadLine()!);

      return (rows, cols);
    }

    public int[,] GetMatrixValues(int rows, int columns)
    {
      var matrix = new int[rows, columns];

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < columns; j++)
        {
          Console.Write($"Ingrese el valor[{i}, {j}]: ");
          while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
          {
            Console.Write("Entrada no válida. Intente de nuevo: ");
          }
        }
      }

      return matrix;
    }

    public void ShowMatrix(int[,] matrix)
    {
      Console.WriteLine("\n Matriz Ingresada:");
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
      }
    }

    public void ShowElement(string label, int value, int row, int column)
    {
      Console.WriteLine();
      Console.WriteLine($"{label}: {value} en la posición [{row}, {column}]");
    }
  }
}
