namespace h_string_concatenation;

class Program
{
    static void Main(string[] args)
    {
        string fname = "John";
        string lname = "Smith";

        Console.WriteLine(string.Concat(fname, " ", lname));
    }
}
