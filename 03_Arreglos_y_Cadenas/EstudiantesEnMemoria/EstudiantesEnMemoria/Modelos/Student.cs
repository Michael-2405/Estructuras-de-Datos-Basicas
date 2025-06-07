namespace EstudiantesEnMemoria.Modelos
{
  public class Student
  {
    public string? Tuition { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Telephone { get; set; }
    public string? Mail { get; set;}
    public string? Career {  get; set; }
    public string? Grade {  get; set; }

    public override string ToString()
    {
      return $"[{Tuition}] {Name} {Surname} | Telefono: {Telephone} | Correo: {Mail} | Carrera: {Career} | Grado: {Grade}";
    }
  }
}
