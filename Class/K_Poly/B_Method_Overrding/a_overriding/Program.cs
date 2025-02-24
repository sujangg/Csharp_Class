namespace a_overriding;

class Dad
{
    public void hi()
    {
        System.Console.WriteLine("Hi Son.");
    }
}
class Son : Dad
{
    public void hi()
    {
        System.Console.WriteLine("Hi Dad.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Son s1 = new Son();
        s1.hi();
        s1.hi();
    }
}
