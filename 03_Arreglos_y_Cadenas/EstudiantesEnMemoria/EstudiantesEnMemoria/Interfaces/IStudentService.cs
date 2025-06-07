using EstudiantesEnMemoria.Modelos;

namespace EstudiantesEnMemoria.Interfaces
{
  /// <summary>
  /// Define operaciones CRUD para la gestión de estudiantes.
  /// </summary>
  public interface IStudentService
  {
    /// <summary>Agrega un nuevo estudiante.</summary>
    /// <param name="student">Estudiante a agregar.</param>
    bool Add(Student student);

    /// <summary>Actualiza un estudiante existente.</summary>
    /// <param name="tuition">Matrícula del estudiante a modificar.</param>
    /// <param name="updatedStudent">Datos nuevos del estudiante.</param>
    bool Update(string tuition, Student updatedStudent);

    /// <summary>Elimina un estudiante por matrícula.</summary>
    /// <param name="tuition">Matrícula del estudiante.</param>
    bool Delete(string tuition);

    /// <summary>Obtiene un estudiante por su matrícula.</summary>
    /// <param name="tuition">Matrícula del estudiante.</param>
    Student? GetByTuition(string tuition);

    /// <summary>Obtiene todos los estudiantes registrados.</summary>
    Student[] GetAll();
  }
}
