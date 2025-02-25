// Creator: Ryder Held
// Date: 2/25/2025
namespace ShapesAndAreas
{
    public class ProgramSAA
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle("red", 1.5, 2.5);
            Console.WriteLine(rectangle1.ToString());

            Circle circle1 = new Circle("blue", 3.75);
            Console.WriteLine(circle1.ToString());
        }
    }
}
