namespace A_Method_Overloading;

class MyCalc
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public int add(int a, int b, int c)
    {
        return (a + b + c);
    }
}
class Program
{

    static void Main(string[] args)
    {
        
        MyCalc obj = new MyCalc();
        Console.WriteLine("The sum is " + obj.add(48, 45));
        Console.WriteLine("The sum is " + obj.add(458, 45, 464));

    }
}
