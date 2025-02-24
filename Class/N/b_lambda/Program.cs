namespace b_lambda;


delegate int myDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        myDel d = (a, b) => (a + b);
        int value = d(12 , 23);
        Console.WriteLine("The sum is " + value + ".");
    }
}
