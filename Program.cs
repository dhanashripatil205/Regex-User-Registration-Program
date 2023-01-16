
namespace Day19RejexAssignment
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Last Name : ");
            string lastname = Console.ReadLine();
            bool val = Pattern.validatePincode(lastname);
            if (val)
            {
                Console.WriteLine("Last Name is Valid.");
            }
            else
            {
                Console.WriteLine("Last Name is not Valid.");

            }
        }
    }
}