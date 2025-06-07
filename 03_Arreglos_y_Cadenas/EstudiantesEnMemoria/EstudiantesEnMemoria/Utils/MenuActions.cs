using EstudiantesEnMemoria.Interfaces;

namespace EstudiantesEnMemoria.Utils
{
  public static class MenuActions
  {
    public static void Add(IStudentService studentService)
    {
      var student = StudentInputValidation.ReadStudentFromConsole();
      if (studentService.Add(student))
        Console.WriteLine("Estudiante agregado de forma correcta");
      else
        Console.WriteLine("Error al agregar el estudiante.");
    }

    public static void Update(IStudentService studentService)
    {
      Console.Write("Ingresa la matrícula del estudiante que quieres modificar: ");
      string tuition = Console.ReadLine()!;

      var exists = studentService.GetByTuition(tuition);
      if (exists == null)
      {
        Console.WriteLine("El estudiante no fue encontrado");
        return;
      }

      var student = StudentInputValidation.ReadStudentFromConsole();
      if (studentService.Update(tuition, student))
        Console.WriteLine("Estudiante actualizado");
      else
        Console.WriteLine("Error actualizando al estudiante");
    }

    public static void Delete(IStudentService studentService)
    {
      Console.Write("Ingresa la matrícula del estudiante que quieres eliminar: ");
      string tuition = Console.ReadLine()!;

      if (studentService.Delete(tuition))
        Console.WriteLine("Estudiante eliminado");
      else
        Console.WriteLine("Estudiante no encontrado");
    }

    public static void Find(IStudentService studentService)
    {
      Console.Write("Ingresa la matrícula del estudiante que quieres buscar: ");
      string tuition = Console.ReadLine()!;

      var student = studentService.GetByTuition(tuition);
      if (student != null)
        Console.WriteLine(student);
      else
        Console.WriteLine("Estudiante no encontrado");
    }

    public static void ShowAll(IStudentService studentService)
    {
      var students = studentService.GetAll();
      if (students.Length == 0)
      {
        Console.WriteLine("No hay estudiantes guardados");
        return;
      }

      foreach (var student in students)
      {
        Console.WriteLine(student);
      }
    }    
  }
}
