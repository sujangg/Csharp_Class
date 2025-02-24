namespace d_lambda;


delegate int myDel(int a , int b);
class Program
{
    static void Main(string[] args)
    {
        myDel d = (a , b) => a > b ? a : b;
        int value = d(3344, 43245);
        Console.WriteLine("The larger value is " + value + ".");

    }
}
