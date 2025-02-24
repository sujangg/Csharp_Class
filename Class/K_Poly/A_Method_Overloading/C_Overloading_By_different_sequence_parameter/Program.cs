namespace C_Overloading_By_different_sequence_parameter;

class MyClass
{
    public void DisplayDetails(int age, string name)
    {
        Console.WriteLine(name + " is " + age + "years old.");
    }
    public void DisplayDetails(string name, int age)
    {
        Console.WriteLine(name + " is " + age + "years old.");
    }
}
class Program
{w
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        Console.WriteLine(26, "Hello, World!");
        Console.WriteLine("Hello, World!", 45);
    }
}
