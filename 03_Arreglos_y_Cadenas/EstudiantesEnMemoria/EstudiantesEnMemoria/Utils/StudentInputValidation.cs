using EstudiantesEnMemoria.Modelos;

namespace EstudiantesEnMemoria.Utils
{
  public static class StudentInputValidation
  {
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
