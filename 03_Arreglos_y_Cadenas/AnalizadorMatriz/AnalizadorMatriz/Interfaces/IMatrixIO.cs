namespace AnalizadorMatriz.Interfaces
{
  public interface IMatrixIO
  {
    (int Rows, int Columns) GetMatrixDimensions();
    int[,] GetMatrixValues(int rows, int columns);
    void ShowMatrix(int[,] matrix);
    void ShowElement(string label, int value, int row, int column);
  }
}
