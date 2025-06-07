using AnalizadorMatriz.Modelos;

namespace AnalizadorMatriz.Interfaces
{
  public interface IMatrixService
  {
    public void LoadMatrix(int[,] matrix);
    MatrixElement GetMaxElement();
    MatrixElement GetMinElement();
  }
}
