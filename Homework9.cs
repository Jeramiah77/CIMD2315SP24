namespace Homework9;

public class Student
{
    private int studentID;
    private string studentName;

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public static List<Student> studentList = new List<Student>();
}

class Program
{
    static void Main()
    {
        
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

      
        Student.studentList.Add(s1);
        Student.studentList.Add(s2);
        Student.studentList.Add(s3);
        Student.studentList.Add(s4);

      
        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

     
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;

     
        Console.WriteLine("Students with GPA greater than the average GPA:");
        foreach (var entry in gradebook)
        {
            if (entry.Value > averageGPA)
            {
                Console.WriteLine($"Student: {entry.Key}, GPA: {entry.Value}");
            }
        }
        
        Console.WriteLine($"Average GPA of all students: {averageGPA}");
    }
}
