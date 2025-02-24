partial class Student
{
    public int roll;
    public string name;

    public Student(int r, string n){
        name = n;
        roll = r;
    }

    
    public void hi()
    {
        Console.WriteLine("Hello");
    }
}