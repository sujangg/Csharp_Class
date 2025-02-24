namespace d_interface_inherit_interface;

interface One

{
    public void MethodOne();
}
 interface Two
 {
    public void MethodTwo();
 }
interface Three : One, Two
{
    public void MethodOne()
    {
        System.Console.WriteLine("I'm body from interface one.");
    }
    public void MethodTwo()
    {
        System.Console.WriteLine("I'm body from interface two.");
    }
    public void MethodThree()
    {
        System.Console.WriteLine("I'm body from interface three.");
    }
}
class Program
{
    static void Main(string[] args)
    {
      Threee t1 = new Program();
      t1.MethodOne();
      t1.MethodTwo();
        t1.MethodThree();
    }
}
