using Salario_Mensual.Models;

namespace Salario_Mensual.Views
{
  public class ConsoleUI
  {
    public void Run()
    {
      Console.Clear();
      PrintTitle("Cálculo de Salario Mensual");

      string name = ReadText("Ingresa tu nombre: ");
      double hours = ReadNumber("Ingresa las horas trabajadas por semana: ");
      double rate = ReadNumber("Ingresa la tarifa por hora: ");

      var employee = new Employee(name, hours, rate);

      Console.Clear();
      PrintTitle("Resultados del Cálculo");
      ShowResults(employee);
    }

    private string ReadText(string message)
    {
      string? input;
      do
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(message);
        Console.ResetColor();

        input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
          PrintError("El valor no puede estar vacío.");
        }

      } while (string.IsNullOrWhiteSpace(input));

      return input.Trim();
    }

    private double ReadNumber(string message)
    {
      double value;
      bool valid;
      do
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(message);
        Console.ResetColor();

        string? input = Console.ReadLine();
        valid = double.TryParse(input, out value) && value >= 0;

        if (!valid)
        {
          PrintError("Ingresa un número válido y positivo.");
        }

      } while (!valid);

      return value;
    }

    private void PrintTitle(string title)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("=======================================");
      Console.WriteLine($"     {title}");
      Console.WriteLine("=======================================");
      Console.ResetColor();
    }

    private void PrintError(string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(message);
      Console.ResetColor();
    }

    private void ShowResults(Employee employee)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"\nEmpleado/a: {employee.Name}");
      Console.WriteLine($"Salario semanal: RD${employee.CalculateWeeklySalary():N2}");
      Console.WriteLine($"Salario mensual: RD${employee.CalculateMonthlySalary():N2}");
      Console.ResetColor();
    }
  }
}
