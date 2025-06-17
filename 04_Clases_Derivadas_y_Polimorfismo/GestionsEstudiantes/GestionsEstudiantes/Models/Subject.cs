namespace GestionEstudiantes.Models
{
  /// <summary>
  /// Representa una asignatura que contiene grupos.
  /// </summary>
  public class Subject
  {
    /// <summary>
    /// Nombre de la asignatura.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Lista de grupos de la asignatura.
    /// </summary>
    public List<Group> Groups { get; set; } = new List<Group>();

    /// <summary>
    /// Inicializa una nueva instancia de <see cref="Subject"/>.
    /// </summary>
    /// <param name="name">Nombre de la asignatura.</param>
    public Subject(string name)
    {
      Name = name;
    }

    /// <summary>
    /// Agrega un grupo a la asignatura.
    /// </summary>
    /// <param name="group">Grupo a agregar.</param>
    public void AddGroup(Group group)
    {
      Groups.Add(group);
    }
  }
}