namespace ICE_Task_3;

public class Circle : Shape, CalculateArea
{


    public double PI = 3.14;
    public double radius { get; set; }

    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        //throw new NotImplementedException();
        return PI * radius * radius;
    }

    public override void Display()
    {
        //base.Display();
        Console.WriteLine("Circle area: {0}", CalculateArea());
    }
}