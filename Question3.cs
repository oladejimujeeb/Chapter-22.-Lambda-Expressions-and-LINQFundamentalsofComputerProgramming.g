namespace Chapter_22._Lambda_Expressions_and_LINQ;

public class Student
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }

    public static void Question3(Student[] students)
    {
        var getStudent = from stu in students where stu.Firstname.CompareTo(stu.Lastname) == -1 select stu;
        foreach (var item in getStudent)
        {
            Console.WriteLine($"{item.Firstname} {item.Lastname}");
        }
    }

    public static void Question4(Student[] students)
    {
        var student = from stu in students where stu.Age >= 18 && stu.Age <= 24 select stu;
        foreach (var item in student)
        {
            Console.WriteLine($"{item.Firstname} {item.Lastname}");
        }
    }

    public static void Question5(Student[] students)
    {
        var student = students.OrderByDescending(x => x.Firstname).ThenByDescending(x => x.Lastname);
        foreach (var item in student)
        {
            Console.WriteLine($"{item.Firstname} {item.Lastname}");
        }
    }
    public static void Question5b (Student[] students)
    {
        var sortStudents = from stu in students orderby stu.Firstname descending, stu.Lastname descending select stu;
        foreach (var item in sortStudents)
        {
            Console.WriteLine($"{item.Firstname} {item.Lastname}");
        }
    }
}