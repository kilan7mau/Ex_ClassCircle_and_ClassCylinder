namespace Ex_ClassCircle_and_ClassCylinder;

public class Cylinder: Circle
{
    // lớp con của Circle là Cylinder (hình trụ).
    // Lớp Cylinder mở rộng lớp Circle bằng cách bổ sung thuộc tính chiều cao
    // cũng như có thể có thêm phương thức lấy thể tích.
    private double height;
    private double volume;
    
    public Cylinder()
    {
        height = 1;
    }
    
    public Cylinder(double radius, double height): base(radius)
    {
        this.height = height;
    }
    
    public Cylinder(double radius, double height, string color): base(radius, color)
    {
        this.height = height;
    }
    
    public double Height
    {
        get => height;
        set => height = value;
    }
    
    public void getVolume(double radius, double height)
    {
        volume = Math.PI * radius * radius * height;
    }
    
    public void getArea(double radius, double height)
    {
        area = 2 * Math.PI * radius * (radius + height);
    }
    
    public override string ToString()
    {
        return $"Radius: {radius}, Color: {color}, Height: {height}, Volume: {volume}";
    }

}