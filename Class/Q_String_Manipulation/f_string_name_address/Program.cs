namespace f_string_name_address;

class Program
{
    static void Main(string[] args)
    {
        string fname = "John";
        string lname = "Smith";
        string address = "123 Main St";
        System.Console.WriteLine(fname + " " + lname + " live in " + address + ".");
        Console.WriteLine("{0} {1} live in {2}.", fname, lname, address);
    }
}
