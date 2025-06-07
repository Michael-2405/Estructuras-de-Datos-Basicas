namespace Suma_Dos_Numeros
{
  public class CompareSum
  {
    private int a;
    private int b;
    private int c;

    public CompareSum(int a, int b, int c)
    {
      this.a = a;
      this.b = b;
      this.c = c;
    }

    public bool IsEqual()
    {
      return (a + b == c || a + c == b || b + c == a);
    }

    public string GetResult()
    {
      return IsEqual() ? "Son Iguales" : "Son diferentes";
    }
  }
}
