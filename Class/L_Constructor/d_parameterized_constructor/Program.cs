namespace d_parameterized_constructor;


class Person
{
    public string FirstName {get; set;}
    public string LasttName {get; set;}

    public Person(string fn, string ln)
    {
        FirstName = fn;
        LasttName = ln;
    }
    static void Main(string[] args)
    {
        Person p1 = new Person("Sujan", "Gurung");
        Console.WriteLine(p1.FirstName + " " + p1.LasttName);

    }
}
