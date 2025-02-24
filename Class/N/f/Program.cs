namespace f;
class Program
{
    static void Main(string[] args)
    {
        var calSum = (int a, int b) =>
        {
            int sum = (a + b);
            return sum;
        };
        Console.WriteLine("The sum is " + calSum(8, 9) + ".");

    }
}
