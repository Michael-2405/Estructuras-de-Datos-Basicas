using EstudiantesEnMemoria.Interfaces;
using EstudiantesEnMemoria.Modelos;

namespace EstudiantesEnMemoria.Servicios
{
  public class StudentService: IStudentService
  {
    private readonly Student[] _students;
    private int _count = 0;

    public StudentService(int capacity = 100)
    {
      _students = new Student[capacity];
    }

    public bool Add(Student student)
    {
      if (_count >= _students.Length) return false;

      if (GetByTuition(student.Tuition) != null) return false;

      _students[_count++] = student;
      return true;
    }

    public bool Update(string tuition, Student updatedStudent)
    {
      for(int i = 0; i<_count; i++)
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

    public bool Delete(string tuition)
    {
      for (int i = 0; i<_count; i++)
      {
        if (_students[i]?.Tuition == tuition)
        {
          for (int j = i; j < _count -1; j++)
          {
            _students[j] = _students[j + 1];
          }

          _students[--_count] = null!;
          return true;
        }
      }
      return false;
    }

    public Student? GetByTuition(string tuition)
    {
      for(int i =0; i<_count; i++)
      {
        if (_students[i]?.Tuition == tuition)
        {
          return _students[i];
        }
      }
      return null;
    }

    public Student[] GetAll()
    {
      return _students.Take(_count).ToArray();
    }
    
  }
}
