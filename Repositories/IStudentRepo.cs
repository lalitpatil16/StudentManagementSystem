using StudentManagementFinal.Models;
public interface IStudentRepo
{
    List<Student> GetAll();
    void Add(Student s);
    void Delete(int id);
}
