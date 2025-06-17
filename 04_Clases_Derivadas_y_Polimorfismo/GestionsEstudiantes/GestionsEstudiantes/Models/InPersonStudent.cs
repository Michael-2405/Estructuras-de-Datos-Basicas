namespace GestionEstudiantes.Models
{
  /// <summary>
  /// Representa un estudiante presencial.
  /// </summary>
  public class InPersonStudent : Student
  {
    public InPersonStudent(string tuition, string name, string surname) : base(tuition, name, surname) { }

    /// <inheritdoc/>
    public override double CalculateFinalGrade() => (ExamGrade * 0.6) + (PracticeGrade * 0.4);
  }
}