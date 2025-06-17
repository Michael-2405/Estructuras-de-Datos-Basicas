using GestionEstudiantes.Models;
using GestionsEstudiantes.Common;

namespace GestionEstudiantes.Models
{
  /// <summary>
  /// Representa un grupo de estudiantes.
  /// </summary>
  public class Group
  {
    /// <summary>
    /// Nombre del grupo.
    /// </summary>
    public string? GroupName { get; set; }

    /// <summary>
    /// Lista de estudiantes del grupo.
    /// </summary>
    public List<Student>? Students { get; set; } = new List<Student>();

    /// <summary>
    /// Inicializa una nueva instancia de <see cref="Group"/>.
    /// </summary>
    /// <param name="groupName">Nombre del grupo.</param>
    public Group(string groupName)
    {
      GroupName = groupName;
    }

    /// <summary>
    /// Agrega un estudiante al grupo.
    /// </summary>
    /// <param name="student">Estudiante a agregar.</param>
    ///  /// <returns>Resultado de la operación.</returns>
    public OperationResult AddStudent(Student student)
    {
      if (Students.Any(s => s.Tuition == student.Tuition))
        return new OperationResult(false, "Ya existe un estudiante con esa matricula");

      Students.Add(student);
      return new OperationResult(true, "Estudiante agregado con exito", student);
    }

    /// <summary>
    /// Registra las calificaciones de un estudiante identificado por su matrícula.
    /// </summary>
    /// <param name="tuition">Matrícula del estudiante.</param>
    /// <param name="exam">Nota del examen.</param>
    /// <param name="practice">Nota de la práctica.</param>
    /// <returns>Resultado de la operación.</returns>
    public OperationResult RegisterStudent(string tuition, double exam, double practice)
    {
      var student = Students.FirstOrDefault(e => e.Tuition == tuition);
      if (student == null)
        return new OperationResult(false, "Estudiante no encontrado");

      student.ExamGrade = exam;
      student.PracticeGrade = practice;

      return new OperationResult(true, "Calificaciones registradas correctamente", student);
    }

    /// <summary>
    /// Muestra la lista de estudiantes y sus calificaciones.
    /// </summary>
    public void ShowList()
    {
      Console.WriteLine($"Grupo: {GroupName}");
      foreach (var e in Students)
      {
        Console.WriteLine(e.ShowInformation());
      }
    }

    /// <summary>
    /// Calcula el porcentaje de estudiantes aprobados.
    /// </summary>
    /// <returns>Porcentaje de estudiantes aprobados.</returns>
    public double CalculateApprovedPercentage()
    {
      if (Students.Count == 0) return 0;
      int approved = Students.Count(e => e.IsApproved());
      double percentage = (approved / (double)Students.Count) * 100;
      return Math.Round(percentage, 2);
    }
  }
}