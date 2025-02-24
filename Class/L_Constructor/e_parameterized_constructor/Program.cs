namespace e_parameterized_constructor;


class Student
{
    string name;
    int roll;

   
    public Student(string name, int roll)
    {
        this.name = name;
        this.roll = roll;
        

    }



    static void Main(string[] args)
    {
        Student s1 = new Student("Sujan Gurung", 3400);
        Console.WriteLine(s1.name + " " s1.roll);
    }
}
