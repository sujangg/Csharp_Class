using F;

namespace F;

class Student
{
    private int roll;
    private string name;

    public int Roll
    {
        get{
            return sroll;
        }
        set
        {
            sroll  = value;
        }
    }
}
public string Name
{
    get
    {
        return sname;
    }
    set
    {
        sname = value;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll();
        s1.Name();
    }
}
