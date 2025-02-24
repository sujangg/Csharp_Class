namespace c_interface_same_method;
using System;
interface Student
{
    public void exam();
}

interface Teacher
{
    public void exam();
}
public class College : Student, Teacher
{
    void Student.exam()
    {
        System.Console.WriteLine("I am a student.");
    }
    void Teacher.exam()
    {
        System.Console.WriteLine("I am a teacher.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new College();
        Teacher t1 = new College();
        s1.exam();
        t1.exam();
        
    }
}
