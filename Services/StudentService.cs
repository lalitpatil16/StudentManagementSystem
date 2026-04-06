using StudentManagementFinal.Models;

public class StudentService
{
    private readonly IStudentRepo _repo;

    public StudentService(IStudentRepo repo)
    {
        _repo = repo;
    }

    public List<Student> GetAll() => _repo.GetAll();
    public void Add(Student s) => _repo.Add(s);
    public void Delete(int id) => _repo.Delete(id);
}
