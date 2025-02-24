namespace C;

static class Shape
{
    public static int length = 34;

    public static int areaSquare()
    {
        return (length * length);

    }
    public static int cube(int a)
    {
        return (a*a*a);
    }
}
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("The length is " + Shape.length);
       Console.WriteLine("The area is " + Shape.areaSquare() + " u. sq.");
       Console.WriteLine("The area is " + Shape.cube(5));
       
    }
}
