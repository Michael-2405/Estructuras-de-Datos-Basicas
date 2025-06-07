using Suma_Dos_Numeros.Models;
using Suma_Dos_Numeros.Services;

namespace Suma_Dos_Numeros.Views
{
  public class ConsoleUI
  {
    public void Run()
    {
      while (true)
      {
        Console.Clear();
        PrintTitle("Comparación de Suma de Números");

        int a = ReadNumber("Ingresa el primer número: ");
        int b = ReadNumber("Ingresa el segundo número: ");
        int c = ReadNumber("Ingresa el tercer número: ");

        var triple = new NumberTriple(a, b, c);
        var comparer = new SumComparer(triple);

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Resultado: {comparer.GetResult()}");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Deseas realizar otra comparación? (S para salir, cualquier otra tecla para continuar): ");
        Console.ResetColor();
        var option = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(option) && option.Trim().ToUpper() == "S")
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("\n Gracias por usar el comparador.");
          Console.ResetColor();
          break;
        }
      }
    }

    private int ReadNumber(string message)
    {
      int value;
      bool valid;
      do
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(message);
        Console.ResetColor();

        string? input = Console.ReadLine();
        valid = int.TryParse(input, out value);

        if (!valid)
        {
          PrintError("Ingresa un número entero válido.");
        }

      } while (!valid);

      return value;
    }

    private void PrintTitle(string title)
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("=========================================");
      Console.WriteLine($"        {title}");
      Console.WriteLine("=========================================");
      Console.ResetColor();
    }

    private void PrintError(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(message);
      Console.ResetColor();
    }

  }
}
