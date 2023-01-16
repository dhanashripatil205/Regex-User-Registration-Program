
namespace Day19RejexAssignment
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Name : ");
            string name = Console.ReadLine();
            bool val = Pattern.validatePincode(name);
            if (val)
            {
                Console.WriteLine("First Name is Valid.");
            }
            else
            {
                Console.WriteLine("First Name is not Valid.");

            }
        }
    }
}