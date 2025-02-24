namespace B_MO_Different_Data_Type;

class MyCalc
{
    public int add(int a, int b)
    {
        return (a + b);
    }
    public double add(double a, double b)
    {
        return (a + b);
    }
}
class Program
{

    static void Main(string[] args)
    {
        
        MyCalc obj = new MyCalc();
        Console.WriteLine("The sum is " + obj.add(48, 45));
        Console.WriteLine("The sum is " + obj.add(45.8, 4.589));

    }
}
