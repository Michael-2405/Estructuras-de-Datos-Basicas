using AnalizadorMatriz.Modelos;

namespace AnalizadorMatriz.Interfaces
{
  // Movido
  public interface IMatrixService
  {
    public void LoadMatrix(int[,] matrix);
    MatrixElement GetMaxElement();
    MatrixElement GetMinElement();
  }
}
