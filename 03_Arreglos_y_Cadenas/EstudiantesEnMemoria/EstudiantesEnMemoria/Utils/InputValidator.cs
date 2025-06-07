namespace EstudiantesEnMemoria.Utils
{ 
  /// <summary>
  /// Provee métodos para validar entradas de usuario.
  /// </summary>
  public static class InputValidator
  {
    /// <summary>
    /// Solicita al usuario una cadena no vacía.
    /// </summary>
    /// <param name="fieldName">Nombre del campo que se solicita.</param>
    /// <returns>Cadena ingresada por el usuario.</returns>
    public static string ReadNonEmptyString(string fieldName)
    {
      string? input;
      do
      {
        Console.Write($"{fieldName}: ");
        input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine($"El campo '{fieldName}' no puede estar vacío. Intenta de nuevo.");
        }

      } while (string.IsNullOrWhiteSpace(input));

      return input!;
    }
  }
}
