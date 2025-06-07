using EstudiantesEnMemoria.Interfaces;
using EstudiantesEnMemoria.Servicios;
using EstudiantesEnMemoria.Utils;

class Program
{
  public static void Main(string[] args)
  {
    IStudentService studentService = new StudentService();

    bool running = true;
    while(running)
    {
      Console.WriteLine("\n===== MENÚ =====");
      Console.WriteLine("1. Agregar estudiante");
      Console.WriteLine("2. Modificar estudiante");
      Console.WriteLine("3. Eliminar estudiante");
      Console.WriteLine("4. Buscar por matrícula");
      Console.WriteLine("5. Mostrar todos");
      Console.WriteLine("6. Salir");
      Console.Write("Seleccione una opción: ");
      var option = Console.ReadLine();

      switch (option)
      {
        case "1": MenuActions.Add(studentService); break;
        case "2": MenuActions.Update(studentService); break;
        case "3": MenuActions.Delete(studentService); break;
        case "4": MenuActions.Find(studentService); break;
        case "5": MenuActions.ShowAll(studentService); break;
        case "6": running = false; break;
        default: Console.WriteLine("Option no valida."); break;
      }
    }

  }
}