namespace EstudiantesEnMemoria.Utils
{
  public static class InputValidator
  {
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
