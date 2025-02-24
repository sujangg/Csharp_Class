namespace J;

abstract class MyClass
{
    public abstract void calculate(double a);
}

class SubclassOne : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Square root = " + Math.Sqr(a));
    }
}

class SubclassTwo : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Square = " + (a * a));
    }
}
class SubclassThree : MyClass
{
    public override void calculate(double a)
    {
        Console.WriteLine("Cube = " + (a * a * a));
    }
}
class Program
{
    static void Main(string[] args)
    {
        SubclassOne obj - new SubclassOne();
     }
}
