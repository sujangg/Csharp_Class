namespace k_string_copy;

class Program
{
    static void Main(string[] args)
    {
        string name = "John";
        // string copy = string.Copy(name);
        string copy = new string(name);
        Console.WriteLine(copy);
        Cosole.WriteLine(name);
        Console.WriteLine("Hello, World!");
    }
}
