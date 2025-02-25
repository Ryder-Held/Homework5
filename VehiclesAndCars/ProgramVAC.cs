// Creator: Ryder Held
// Date: 2/25/2025
namespace VehiclesAndCars
{
    public class ProgramVAC
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("Lamborghini", "Lamborghini Urus", 2018, 4);
            Console.WriteLine(car1.ToString());

            Motorcycle motorcycle1 = new Motorcycle("BWM", "F 900 XR", 2025, false);
            Console.WriteLine(motorcycle1.ToString());
        }
    }
}
