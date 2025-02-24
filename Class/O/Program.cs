namespace O;

static class Math
{
    static void Add(int a, int b)
    {
        System.Console.WriteLine("Addition is " + (a + b) + ".");
}
class Program
{
    static void Main(string[] args)
    {
        Math.Add(12,12);
    }
}
}