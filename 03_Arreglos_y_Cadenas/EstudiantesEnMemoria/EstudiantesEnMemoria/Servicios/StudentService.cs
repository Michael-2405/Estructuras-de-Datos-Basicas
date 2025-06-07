using EstudiantesEnMemoria.Interfaces;
using EstudiantesEnMemoria.Modelos;

namespace EstudiantesEnMemoria.Servicios
{ /// <summary>
  /// Servicio que gestiona estudiantes en memoria usando un arreglo fijo.
  /// </summary>
  public class StudentService : IStudentService
  {
    private readonly Student[] _students;
    private int _count = 0;

    /// <summary>
    /// Crea una nueva instancia de StudentService con capacidad especificada.
    /// </summary>
    /// <param name="capacity">Capacidad máxima de estudiantes.</param>
    public StudentService(int capacity = 100)
    {
      _students = new Student[capacity];
    }

    /// <inheritdoc/>
    public bool Add(Student student)
    {
      if (_count >= _students.Length) return false;
      if (GetByTuition(student.Tuition!) != null) return false;

      _students[_count++] = student;
      return true;
    }

    /// <inheritdoc/>
    public bool Update(string tuition, Student updatedStudent)
    {
      for (int i = 0; i < _count; i++)
      {
        if (_students[i]?.Tuition == tuition)
        {
          updatedStudent.Tuition = tuition;
          _students[i] = updatedStudent;
          return true;
        }
      }
      return false;
    }

    /// <inheritdoc/>
    public bool Delete(string tuition)
    {
      for (int i = 0; i < _count; i++)
      {
        if (_students[i]?.Tuition == tuition)
        {
          for (int j = i; j < _count - 1; j++)
          {
            _students[j] = _students[j + 1];
          }
          _students[--_count] = null!;
          return true;
        }
      }
      return false;
    }

    /// <inheritdoc/>
    public Student? GetByTuition(string tuition)
    {
      for (int i = 0; i < _count; i++)
      {
        if (_students[i]?.Tuition == tuition)
        {
          return _students[i];
        }
      }
      return null;
    }

    /// <inheritdoc/>
    public Student[] GetAll()
    {
      return _students.Take(_count).ToArray();
    }
  }
}
