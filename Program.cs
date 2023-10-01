using System;
using System.Collections;
using System.Collections.Generic;

public class Student
{
    public string Name { get; }

    public Student(string name)
    {
        Name = name;
    }
}

public class Group : IEnumerable<Student>
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public IEnumerator<Student> GetEnumerator()
    {
        return students.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Group group = new Group();
        group.AddStudent(new Student("Папа"));
        group.AddStudent(new Student("Мимик"));
        group.AddStudent(new Student("Я"));

        foreach (Student student in group)
        {
            Console.WriteLine(student.Name);
        }
    }
}
