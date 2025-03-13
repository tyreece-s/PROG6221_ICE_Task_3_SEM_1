namespace ICE_Task_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Shape Calculator OS");

        
        Console.WriteLine("-----------------------");
        
        Rectangle rectangle = new Rectangle("Rectangle", 10.00, 5.00);
        rectangle.Display();
        
        Console.WriteLine("-----------------------");
        
        Circle circle = new Circle("Circle", 10.00);
        circle.Display();
        
        
    }
}