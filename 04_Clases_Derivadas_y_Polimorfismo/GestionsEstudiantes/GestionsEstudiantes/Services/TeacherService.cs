using GestionEstudiantes.Helpers;
using GestionEstudiantes.Models;
using GestionsEstudiantes.Common;

namespace GestionsEstudiantes.Services
{
  /// <summary>
  /// Servicio que permite al maestro gestionar asignaturas y grupos.
  /// </summary>
  public class TeacherService
  {
    /// <summary>
    /// Solicita al usuario el nombre de una asignatura y la asigna al maestro.
    /// </summary>
    /// <param name="teacher">El maestro al que se le asignará la asignatura.</param>
    public OperationResult AddSubjectToTeacher(Teacher teacher)
    {
      string subjectName = InputHelper.ReadEmptyString("Nombre de la asignatura: ");

      if (teacher.Subjects.Any(s => s.Name == subjectName))
      {
        return new OperationResult
        {
          Success = false,
          Message = "Ya existe una asignatura con ese nombre."
        };
      }

      var subject = new Subject(subjectName);
      teacher.AddSubject(subject);

      return new OperationResult
      {
        Success = true,
        Message = $"Asignatura '{subjectName}' agregada correctamente."
      };
    }

    /// <summary>
    /// Solicita al usuario el nombre de un grupo y lo agrega a la asignatura.
    /// </summary>
    /// <param name="subject">La asignatura a la cual se le agregará el grupo.</param>
    public OperationResult AddGroupToSubject(Subject subject)
    {
      string groupName = InputHelper.ReadEmptyString("Nombre del grupo: ");

      // Validar si el grupo ya existe en la asignatura para evitar duplicados
      if (subject.Groups.Any(g => g.GroupName.Equals(groupName, StringComparison.OrdinalIgnoreCase)))
      {
        return new OperationResult(false, $"El grupo '{groupName}' ya existe en la asignatura.");
      }

      var group = new Group(groupName);
      subject.AddGroup(group);

      return new OperationResult(true, $"Grupo '{groupName}' agregado correctamente.");
    }
  }
}
