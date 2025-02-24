namespace c_parameterized_constructor;

class Car
{
    string name;
    int price;


    public Car(string n, int p)
    {
        name = n;
        price = p;
    }
    public void displayDetails()
        {
            System.Console.WriteLine("Name is " + name);
            System.Console.WriteLine("Price is " + price);
        }
    }
class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car("Bug", 500000000);
        c1.displayDetails();
    }
}
