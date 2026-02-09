var rectangle1 = new Rectangle(5, 10);
Console.WriteLine($"Width is: {rectangle1.Width}");
Console.WriteLine($"Height is: {rectangle1.Height}");
Console.WriteLine($"Area is: {rectangle1.CalculateArea()}");
Console.WriteLine($"Circumference is: {rectangle1.CalculateCircumference}");

var rectangle2 = new Rectangle(2, 3);
Console.WriteLine($"Width is: {rectangle2.Width}");
Console.WriteLine($"Height is: {rectangle2.Height}");
Console.WriteLine($"Area is: {rectangle2.CalculateArea}");
Console.WriteLine($"Circumference is: {rectangle2.CalculateCircumference}");

Console.ReadKey();
class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        Height = GetLengthOrDefault(height, nameof(Height));
    }
    private int GetLengthOrDefault(int length, string name)
    {
        int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }
    public int CalculateArea() => Width * Height;
    public int CalculateCircumference() => 2 * (Width + Height);
}
