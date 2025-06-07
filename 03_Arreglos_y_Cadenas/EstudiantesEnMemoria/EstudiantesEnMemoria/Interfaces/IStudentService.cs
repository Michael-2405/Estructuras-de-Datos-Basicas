using EstudiantesEnMemoria.Modelos;

namespace EstudiantesEnMemoria.Interfaces
{
  public interface IStudentService
  {
    bool Add(Student student);
    bool Update(string tuition, Student updatedStudent);
    bool Delete(string tuition);
    Student? GetByTuition(string tuition);
    Student[] GetAll();
  }
}
