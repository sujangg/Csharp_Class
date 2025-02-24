namespace E;

class Student
{
    public int roll;

    public int DisplayRoll(int a)
    {
        roll = a;
        return roll;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Console.WriteLine("The roll is " + s1.DisplayRoll(3));
    }
}
