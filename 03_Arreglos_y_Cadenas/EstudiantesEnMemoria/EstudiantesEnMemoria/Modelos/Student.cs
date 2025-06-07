namespace EstudiantesEnMemoria.Modelos
{
  /// <summary>
  /// Representa un estudiante con información básica.
  /// </summary>
  public class Student
  {
    /// <summary>Matrícula del estudiante.</summary>
    public string? Tuition { get; set; }

    /// <summary>Nombre del estudiante.</summary>
    public string? Name { get; set; }

    /// <summary>Apellido del estudiante.</summary>
    public string? Surname { get; set; }

    /// <summary>Teléfono de contacto del estudiante.</summary>
    public string? Telephone { get; set; }

    /// <summary>Correo electrónico del estudiante.</summary>
    public string? Mail { get; set; }

    /// <summary>Carrera que cursa el estudiante.</summary>
    public string? Career { get; set; }

    /// <summary>Grado académico o nivel del estudiante.</summary>
    public string? Grade { get; set; }

    /// <summary>Retorna una representación en texto del estudiante.</summary>
    public override string ToString()
    {
      return $"[{Tuition}] {Name} {Surname} | Telefono: {Telephone} | Correo: {Mail} | Carrera: {Career} | Grado: {Grade}";
    }
  }
}
