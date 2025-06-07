namespace Gestion_Estudiantes.Models
{
  /// <summary>
  /// Representa un estudiante base con matrícula, nombre, apellidos y calificaciones.
  /// </summary>
  public abstract class Student
  {
    /// <summary>
    /// Matrícula única del estudiante.
    /// </summary>
    public string Tuition { get; set; }

    /// <summary>
    /// Nombre del estudiante.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Apellido del estudiante.
    /// </summary>
    public string? Surname { get; set; }

    /// <summary>
    /// Nota obtenida en el examen.
    /// </summary>
    public double ExamGrade { get; set; }

    /// <summary>
    /// Nota obtenida en la práctica.
    /// </summary>
    public double PracticeGrade { get; set; }

    /// <summary>
    /// Nota final calculada según las reglas de cada tipo de estudiante.
    /// </summary>
    public double FinalGrade { get; set; }

    /// <summary>
    /// Inicializa una nueva instancia de <see cref="Student"/>.
    /// </summary>
    /// <param name="tuition">Matrícula del estudiante.</param>
    /// <param name="name">Nombre del estudiante.</param>
    /// <param name="surname">Apellido del estudiante.</param>
    public Student(string tuition, string name, string surname)
    {
      Tuition = tuition;
      Name = name;
      Surname = surname;
    }

    /// <summary>
    /// Calcula la nota final según el tipo de estudiante.
    /// </summary>
    /// <returns>Nota final ponderada.</returns>
    public abstract double CalculateFinalGrade();

    /// <summary>
    /// Muestra la información básica del estudiante y su nota final.
    /// </summary>
    /// <returns>Cadena con la información del estudiante.</returns>
    public virtual string ShowInformation()
    {
      return $"Matricula: {Tuition}, Nombre: {Name}, Apellido: {Surname}, Final: {CalculateFinalGrade()}";
    }

    /// <summary>
    /// Determina si el estudiante está aprobado según su nota final.
    /// </summary>
    /// <returns><c>true</c> si está aprobado; de lo contrario, <c>false</c>.</returns>
    public bool IsApproved() => CalculateFinalGrade() >= 70;
  }
}
