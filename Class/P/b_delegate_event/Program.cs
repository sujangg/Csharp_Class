namespace b_delegate_event;

public delegate void TrafficLightChangeHandler(string color);

public class TrafficLight
{
    public event TrafficLightChangeHandler TrafficLightChanged;

    public void ChangeLightr()
    {
        System.Console.WriteLine("Traffic Light Changed to " + color + "color");
        TrafficLightChanged.Invoke(color);
    }
}
public class Car
{
    public void ResponseToLightChange(string color)
    {
        if(lightColor == "red")
        {
            System.Console.WriteLine("Stop the Car");
        }
        else if(lightColor == "green")
        {
            System.Console.WriteLine("Go the Car");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight();
        Car car = new Car();
        trafficLight.TrafficLightChanged += new TrafficLightChangeHandler(car.ResponseToLightChange);
        trafficLight.ChangeLightr("red");
        trafficLight.ChangeLightr("green");
    }
}
