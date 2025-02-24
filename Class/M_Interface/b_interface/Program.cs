namespace b_interface;

interface Student
{
    public void Learn();
}
interface Teacher
{
    public void Teach();
}
class College : Student, Teacher
{
    public void Learn()
    {
        System.Console.WriteLine("Student learned");
    }

    public void Teach()
    {
        System.Console.WriteLine("Teacher teached");
    }
}
class Program
{
    static void Main(string[] args)
    {
College c1 = new College();
c1.Teach();
c1.Learn();
    }
}
