

class Engine
{
    public void Start()
    {
        Console.WriteLine("двигатель запущен");
    }
}
abstract class Transport
{
    public Engine Engine { get; set; }
    public abstract void Move();
}
class Car : Transport
{
    public Car()
    { 
     Engine = new Engine();
    }
    public override void Move()
    {
        Engine.Start();
        Console.WriteLine("машина едет");
    }
}
class Plane : Transport
{
    public Plane()
    {
        Engine = new Engine();
    }
    public override void Move()
    {
       
        Engine.Start();
        Console.WriteLine("самолет летит");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        var car = new Car();
        car.Move();

        var plane = new Plane();
        plane.Move();
    }
}