namespace D;

static class Student
{
    public static string fname = "AVC";
    public static string lname = "WRW";
    public static int marks = 65;

    public static void display()
    {
        Console.WriteLine("Details of student:");
    }

} 
class Program
{
    static void Main(string[] args)
    {
        Student.display();
        Console.WriteLine("First name = " + Student.fname);
        Console.WriteLine("Last name = " + Student.lname);
        Console.WriteLine("Obtained marks = " + Student.marks);
            }
}
