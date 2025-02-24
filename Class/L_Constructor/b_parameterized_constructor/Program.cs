namespace b_parameterized_constructor;

class MyClass
{
    public MyClass(int a)
    {
        System.Console.WriteLine("Square is " + (a + a));
    }

    public MyClass(int a, int b, int c)
    {
        System.Console.WriteLine("Volume is " + (a * b * c));
    }
}
class Program
{
    static void Main(string[] args)
    {
        new MyClass(25);
        new MyClass(25, 25, 25);

        }
}
