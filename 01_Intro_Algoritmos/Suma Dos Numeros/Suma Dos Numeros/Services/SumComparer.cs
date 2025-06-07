using Suma_Dos_Numeros.Interfaces;
using Suma_Dos_Numeros.Models;

namespace Suma_Dos_Numeros.Services
{
  public class SumComparer : ISumComparer
  {
    private readonly NumberTriple _triple;

    public SumComparer(NumberTriple triple)
    {
      _triple = triple;
    }

    public bool IsEqual()
    {
      return (_triple.A + _triple.B == _triple.C ||
              _triple.A + _triple.C == _triple.B ||
              _triple.B + _triple.C == _triple.A);
    }

    public string GetResult()
    {
      return IsEqual() ? "✅ Son Iguales" : "❌ Son Diferentes";
    }
  }
}
