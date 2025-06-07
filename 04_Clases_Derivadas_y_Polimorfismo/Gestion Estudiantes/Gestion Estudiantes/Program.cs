using Gestion_Estudiantes.Models;
using Gestion_Estudiantes.Services;

class Program
{
  /// <summary>
  /// Punto de entrada principal del programa.
  /// Ejecuta flujo completo: crear maestro, asignar asignatura y grupo, registrar estudiantes, calificaciones y mostrar resultados.
  /// </summary>
  public static void Main(string[] args)
  {
    var teacher = new Teacher("Michael Espinosa");

    var teacherService = new TeacherService();
    var groupService = new GroupService();

    // Asigna una materia al maestro
    teacherService.AddSubjectToTeacher(teacher);

    // Crea una materia (simulada) y asigna un grupo
    var subject = new Subject("Estructura de Datos");
    teacherService.AddGroupToSubject(subject);

    var group = subject.Groups.First();

    // Registro de estudiantes y calificaciones
    groupService.RegisterStudents(group);
    groupService.RegisterGrades(group);

    // Muestra resultados
    groupService.ShowResults(group);
  }
}