namespace LessonPrac.Methods;

internal class StudentService
{
    private List<Student> _students = new List<Student>();

    public void AddStudent(Student student)
    {
        _students.Add(student);
        Console.WriteLine("Student added successfully.");
    }

    public void RemoveStudent(int id)
    {
        Student student = _students.FirstOrDefault(x => x.Id == id);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        _students.Remove(student);
        Console.WriteLine("Student removed.");
    }
    public Student GetStudent(int id)
    {
        return _students.FirstOrDefault(x => x.Id == id);
    }

    public void ShowAllStudents()
    {
        foreach (Student student in _students)
        {
            student.ShowInfo();
            Console.WriteLine("----------------");
        }
    }
    public double GetAverageGrade()
    {
        if (_students.Count == 0)
        {
            return 0;
        }

        double sum = 0;

        foreach (Student student in _students)
        {
            sum += student.Grade;
        }

        return sum / _students.Count;
    }
}
