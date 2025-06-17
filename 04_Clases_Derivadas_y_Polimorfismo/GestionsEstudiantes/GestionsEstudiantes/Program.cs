using GestionEstudiantes.Models;
using GestionsEstudiantes.Services;

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
    
    // Asigno una materia al maestro
    var subjectResult = teacherService.AddSubjectToTeacher(teacher);
    if ((bool)!subjectResult.Success)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(subjectResult.Message);
      Console.ResetColor();
      return;
    }

    // Creo una materia y la asigno a un grupo
    var subject = new Subject("Estructura de Datos");

    var groupResult = teacherService.AddGroupToSubject(subject);
    if ((bool)!groupResult.Success)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(groupResult.Message);
      Console.ResetColor();
      return;
    }
    Console.WriteLine(groupResult.Message);

    var group = subject.Groups.First();

    // Registro de los estudiantes y sus calificaciones
    groupService.RegisterStudents(group);
    groupService.RegisterGrades(group);

    // Muestro los resultados
    groupService.ShowResults(group);
  }
}