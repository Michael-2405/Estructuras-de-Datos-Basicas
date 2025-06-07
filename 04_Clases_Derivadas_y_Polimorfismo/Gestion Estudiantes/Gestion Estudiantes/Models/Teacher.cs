namespace Gestion_Estudiantes.Models
{
  /// <summary>
  /// Representa un profesor que tiene una lista de asignaturas.
  /// </summary>
  public class Teacher
  {
    /// <summary>
    /// Nombre del profesor.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Lista de asignaturas del profesor.
    /// </summary>
    public List<Subject> Subjects { get; set; } = new List<Subject>();

    /// <summary>
    /// Inicializa una nueva instancia de <see cref="Teacher"/>.
    /// </summary>
    /// <param name="name">Nombre del profesor.</param>
    public Teacher(string name)
    {
      Name = name;
    }

    /// <summary>
    /// Agrega una asignatura a la lista del profesor.
    /// </summary>
    /// <param name="subject">Asignatura a agregar.</param>
    public void AddSubject(Subject subject)
    {
      Subjects.Add(subject);
    }
  }
}
