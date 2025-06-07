using Suma_Dos_Numeros;

class Program
{
  public static void Main(string[] args)
  {
    Console.Write("Ingresa el primer numero: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresa el segundo numero: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresa el tercer numero: ");
    int c = Convert.ToInt32(Console.ReadLine());

    CompareSum compareSum = new CompareSum(a, b, c);
    string resultado = compareSum.GetResult();

    Console.WriteLine($"El resultado es: {resultado}");
  }
}
