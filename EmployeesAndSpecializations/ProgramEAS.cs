// Creator: Ryder Held
// Date: 2/25/2025
namespace EmployeesAndSpecializations
{
    public class ProgramEAS
    {
        public static void Main(string[] args)
        {
            Manager manager1 = new Manager("Abe Sanders", 320456, 876);
            Console.WriteLine(manager1.ToString());

            Engineer engineer1 = new Engineer("Garry Greg", 234007.34, "Civil Engineering");
            Console.WriteLine(engineer1.ToString());
        }
    }
}
