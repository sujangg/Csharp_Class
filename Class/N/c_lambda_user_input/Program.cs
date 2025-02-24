namespace b_lambda
{
    delegate int myDel(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            
            myDel d = (a, b) => (a + b);
            int value = d(num1, num2);
            
            Console.WriteLine("The sum is " + value + ".");
        }
    }
}