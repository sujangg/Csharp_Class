namespace a_interface;

interface Nepal
{
    public void hi();
    
}
class Country : Nepal
{
    public void hi()
    {
        System.Console.WriteLine("Hi, Nepal");
    }
}

class Program
{
    static void Main(string[] args)
    {
Country c1 = new Country();
c1.hi();
    }
}
