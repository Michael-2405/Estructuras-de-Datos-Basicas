namespace JuegoDeCartas.Servicios
{
  /// <summary>
  /// Clase auxiliar para la entrada por consola.
  /// </summary>
  public class InputHelper
  {
    /// <summary>
    /// Solicita al usuario un número entero positivo.
    /// </summary>
    /// <param name="message">Mensaje a mostrar.</param>
    /// <returns>Número entero positivo ingresado.</returns>
    public static int ReadPositiveInt(string message)
    {
      int value;
      do
      {
        Console.Write(message);
      } while (!int.TryParse(Console.ReadLine(), out value) || value <= 0);

      return value;
    }
  }
}
