namespace GestionEstudiantes.Models
{
  /// <summary>
  /// Representa un estudiante virtual.
  /// </summary>
  public class VirtualStudent : Student
  {
    public VirtualStudent(string tuition, string name, string surname) : base(tuition, name, surname) { }

    /// <inheritdoc/>
    public override double CalculateFinalGrade() => (ExamGrade * 0.7) + (PracticeGrade * 0.3);
  }
}