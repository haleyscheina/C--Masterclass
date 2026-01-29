//var rectangle1 = new Rectangle(5, 10); //no constructor
var rectangle1 = new Rectangle();
Console.WriteLine($"Width is: {rectangle1.width}");
Console.WriteLine($"Height is: {rectangle1.height}");

/*access modifiers
 * - private members can only bw accessed within the class it belongs to
 * - public members can be accessed everywhere
 */

Console.ReadKey();

class Rectangle
{
    //default access modifier is private, hence "'Rectangle.width' is inaccessible due to its protection level" error
    //int width;
    //int height;

    //in order to make width and height accessible outside of the Rectangle class, add public access modifier
    public int width;
    public int height;

    void DummyMethod()
    {
        //works because code belongs to Rectangle class
        Console.WriteLine($"Height is {height}");
    }
}
