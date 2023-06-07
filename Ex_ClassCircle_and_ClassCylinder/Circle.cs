namespace Ex_ClassCircle_and_ClassCylinder;

public class Circle
{
    //Thiết kế và triển khai lớp Circle (hình tròn)
    
    public double radius;
    public string color;
    public double area;
    
    public Circle()
    {
        radius = 1;
        color = "red";
    }
    
    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }
    
    public double Radius
    {
        get => radius;
        set => radius = value;
    }
    
    public string Color
    {
        get => color;
        set => color = value;
    }
    
    public void getArea(double radius)
    {
        area = Math.PI * radius * radius;
    }
    
    public override string ToString()
    {
        return $" Radius: {radius}, Color: {color}, Area: {area}";
    }
}