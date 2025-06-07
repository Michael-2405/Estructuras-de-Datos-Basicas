using Gestion_Estudiantes.Helpers;
using Gestion_Estudiantes.Models;

namespace Gestion_Estudiantes.Services
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
    public void AddSubjectToTeacher(Teacher teacher)
    {
      string subjectName = InputHelper.ReadEmptyString("Nombre de la asignatura: ");
      var subject = new Subject(subjectName);
      teacher.AddSubject(subject);
    }

    /// <summary>
    /// Solicita al usuario el nombre de un grupo y lo agrega a la asignatura.
    /// </summary>
    /// <param name="subject">La asignatura a la cual se le agregará el grupo.</param>
    public void AddGroupToSubject(Subject subject)
    {
      string groupName = InputHelper.ReadEmptyString("Nombre del grupo: ");
      var group = new Group(groupName);
      subject.AddGroup(group);
    }
  }
}
