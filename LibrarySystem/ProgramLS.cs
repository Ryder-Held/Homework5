// Creator: Ryder Held
// Date: 2/25/2025
namespace LibrarySystem
{
    public class ProgramLS
    {
        public static void Main(string[] args)
        {
            EBook eBook1 = new EBook("Dance of the Firefly", "Jerry Birb", 1989, 4.3);
            Console.WriteLine(eBook1.ToString());

            PrintedBook pageBook1 = new PrintedBook("Dance of the Firefly", "Jerry Birb", 1989, 183);
            Console.WriteLine(pageBook1.ToString());
        }
    }
}
