namespace Gestion_Estudiantes.Helpers
{
  /// <summary>
  /// Clase auxiliar para leer y validar entradas desde consola.
  /// </summary>
  /// 
  public static class InputHelper
  {
    /// <summary>
    /// Solicita al usuario una cadena no vacía.
    /// </summary>
    public static string ReadEmptyString(string message)
    {
      string? input;
      do
      {
        Console.Write(message);
        input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
          Console.WriteLine("Entrada vacia. Ingrese algo valido maestro");
      } while (string.IsNullOrWhiteSpace(input));

      return input.Trim();
    }

    /// <summary>
    /// Solicita un número entero validado, opcionalmente entre un mínimo y máximo.
    /// </summary>
    public static int ReadSafeInteger(string message,int? min =null, int? max = null)
    {
      int result;
      while (true)
      {
        Console.Write(message);
        string? input = Console.ReadLine();

        if(int.TryParse(input, out result))
        {
          if((min.HasValue && result < min)  || (max.HasValue && result > max))
          {
            Console.WriteLine($"El numero debe estar entre {min} y {max}");
            continue;
          }
          return result;
        }
        Console.WriteLine("Entrada invalida. Por favor ingrese un numero entero");
      }
    }
    /// <summary>
    /// Solicita un número decimal validado, opcionalmente entre un mínimo y máximo.
    /// </summary>
    public static double ReadSafeDouble(string message, double? min = null, int? max = null)
    {
      double result;
      while (true)
      {
        Console.Write(message);
        string? input = Console.ReadLine();

        if(double.TryParse(input, out result))
        {
          if((min.HasValue && result < min) || (max.HasValue && result > max))
          {
            Console.WriteLine($"El numero debe estar entre {min} y {max}");
          }
          return result;
        }
        Console.WriteLine("Entrada invalida. Ingrese un numero con decimales maestro.");
      }
    }
  }
}
