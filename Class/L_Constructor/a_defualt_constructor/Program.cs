namespace a_defualt_constructor;

class Student
{
    public Student()
    {
        System.Console.WriteLine("Hello!");
    }
}
class Program
{
    static void Main(string[] args)
    {
// Student obj = new Student();
    new Student();
    }
}
