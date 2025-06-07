namespace JuegoDeCartas.Servicios
{
  public class InputHelper
  {
    public static int ReadPositiveInt(string message)
    {
      int value;
      do
      {
        Console.Write(message);
      } while(!int.TryParse(Console.ReadLine(), out value) || value <= 0);

      return value;
    }
  }
}
