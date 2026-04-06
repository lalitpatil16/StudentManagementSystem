using StudentManagementFinal.Models;

public class StudentRepo : IStudentRepo
{
    private static List<Student> students = new();

    public List<Student> GetAll() => students;

    public void Add(Student s) => students.Add(s);

    public void Delete(int id)
    {
        var s = students.FirstOrDefault(x => x.Id == id);
        if (s != null) students.Remove(s);
    }
}
