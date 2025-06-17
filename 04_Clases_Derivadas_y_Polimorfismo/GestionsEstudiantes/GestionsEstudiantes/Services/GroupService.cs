using GestionEstudiantes.Helpers;
using GestionEstudiantes.Models;
using GestionsEstudiantes.Common;

namespace GestionsEstudiantes.Services
{
  /// <summary>
  /// Servicio para gestionar operaciones relacionadas con grupos y estudiantes.
  /// </summary>
  public class GroupService
  {
    /// <summary>
    /// Registra estudiantes en un grupo.
    /// </summary>
    /// <param name="group">Grupo donde se registrarán los estudiantes.</param>
    /// 

    public OperationResult RegisterStudents(Group group)
    {
      Console.WriteLine("\n== Registro de Estudiantes ==");
      int amount = InputHelper.ReadSafeInteger("Cantidad: ", 1);

      for (int i = 0; i < amount; i++)
      {
        Console.WriteLine($"\n Estudiante #{i + 1}:");

        string tuition;
        do
        {
          tuition = InputHelper.ReadEmptyString("Matricula: ");
          if (group.Students.Any(s => s.Tuition == tuition))
          {
            Console.WriteLine("Ya hay un estudiante con esa matricula. Intenta con otra");
            tuition = null;
          }
        } while (string.IsNullOrEmpty(tuition));

        string name = InputHelper.ReadEmptyString("Nombre: ");
        string surname = InputHelper.ReadEmptyString("Apellido: ");
        int type = InputHelper.ReadSafeInteger("Tipo (1 = Presencial, 2 = A Distancia): ", 1, 2);

        Student student = type == 1 ? new InPersonStudent(tuition, name, surname) : new VirtualStudent(tuition, name, surname);

        group.AddStudent(student);
      }

      return new OperationResult
      {
        Success = true,
        Message = $"{amount} estudiante(s) registrados exitosamente."
      };
    }

    /// <summary>
    /// Registra las calificaciones de los estudiantes en un grupo.
    /// </summary>
    /// <param name="group">Grupo donde se registrarán las calificaciones.</param>
    public OperationResult RegisterGrades(Group group)
    {
      Console.WriteLine("\n== Registro de Calificaciones ==");

      foreach (var student in group.Students)
      {
        Console.WriteLine($"\n{student.Tuition} - {student.Name} {student.Surname}");

        student.ExamGrade = InputHelper.ReadSafeDouble("Nota Examen: ", 0, 100);
        student.PracticeGrade = InputHelper.ReadSafeDouble("Nota Practica: ", 0, 100);
        student.FinalGrade = student.CalculateFinalGrade();
      }

      return new OperationResult
      {
        Success = true,
        Message = "Calificaciones registradas correctamente."
      };
    }

    /// <summary>
    /// Muestra en consola el listado de estudiantes con sus calificaciones del grupo,
    /// destacando con colores los aprobados y reprobados, además de mostrar estadísticas generales.
    /// </summary>
    /// <param name="group">El grupo de estudiantes cuyas calificaciones se mostrarán.</param>

    public void ShowResults(Group group)
    {
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("\n==============================================");
      Console.WriteLine($"    CALIFICACIONES - {group.GroupName.ToUpper()}");
      Console.WriteLine("==============================================");
      Console.ResetColor();

      Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,8} | {4,8} | {5,8}",
        "Matrícula", "Nombre", "Apellido", "Examen", "Práctica", "Final");
      Console.WriteLine(new string('-', 75));

      foreach (var student in group.Students)
      {
        Console.ForegroundColor = student.IsApproved() ? ConsoleColor.Green : ConsoleColor.Red;

        Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,8:F2} | {4,8:F2} | {5,8:F2}",
            student.Tuition, student.Name, student.Surname,
            student.ExamGrade, student.PracticeGrade, student.FinalGrade);

        Console.ResetColor();
      }

      int total = group.Students.Count;
      int aprobados = group.Students.Count(s => s.IsApproved());
      double porcentaje = group.CalculateApprovedPercentage();

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("\n==============================================");
      Console.WriteLine($">> Total Estudiantes: {total}");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($">> Aprobados: {aprobados}");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($">> Reprobados: {total - aprobados}");
      Console.ResetColor();
      Console.WriteLine($">> % de Aprobación: {porcentaje:F2}%");
      Console.WriteLine("==============================================\n");
    }
  }
}
