namespace a_delegate_event;

public delegate string MyDelegate(string str);

class EventPro
{
    event MyDelegate MyEvent;

    public EventPro()
    {
        this.MyEvent += new MyDelegate(this.DisplayMessage);

    }

    public string DisplayMessage(string message)
    {
        return "What's Up " + message;
    }


    static void Main(string[] args)
    {
        EventPro obj = new EventPro();
        string result = obj.MyEvent("Sanothimi Campus");
        System.Console.WriteLine(result);
    }
}
