using EstudiantesEnMemoria.Modelos;

namespace EstudiantesEnMemoria.Utils
{/// <summary>
 /// Provee lógica para capturar todos los campos de un estudiante desde la consola.
 /// </summary>
  public static class StudentInputValidation
  {
    /// <summary>
    /// Solicita al usuario los datos de un estudiante.
    /// </summary>
    /// <returns>Instancia de Student con los datos capturados.</returns>
    public static Student ReadStudentFromConsole()
    {
      string tuition = InputValidator.ReadNonEmptyString("Matrícula");
      string name = InputValidator.ReadNonEmptyString("Nombre");
      string surname = InputValidator.ReadNonEmptyString("Apellido");
      string telephone = InputValidator.ReadNonEmptyString("Teléfono");
      string mail = InputValidator.ReadNonEmptyString("Correo");
      string career = InputValidator.ReadNonEmptyString("Carrera");
      string grade = InputValidator.ReadNonEmptyString("Grado");

      return new Student
      {
        Tuition = tuition,
        Name = name,
        Surname = surname,
        Telephone = telephone,
        Mail = mail,
        Career = career,
        Grade = grade
      };
    }
  }
}
