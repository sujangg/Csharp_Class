namespace e_lambda;

delegate void myDel(int a, int b);
class Program
{
    static void Main(string[] args)
    {
        myDel d = (a , b) =>
        {
            System.Console.WriteLine("The result = " + (a + b) + ".");
            System.Console.WriteLine("End of the program.");
        };

           d(2, 4);
         }
}
