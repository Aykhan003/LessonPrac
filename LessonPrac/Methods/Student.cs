namespace LessonPrac.Methods;

internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public Student(int id, string name, int age, double grade)
    {
        Id = id;
        Name = name;
        Age = age;
        Grade = grade;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade: {Grade}");
    }
    public bool IsPassed()
    {
        return Grade >= 51;
    }
}
