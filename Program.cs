
namespace Day19RejexAssignment
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Name : ");
            string name = Console.ReadLine();
            bool val = Pattern.validateName(name);

            Console.WriteLine("Please enter the Last Name : ");
            string lastname = Console.ReadLine();
            bool val2 = Pattern.validateLastName(lastname);

            Console.WriteLine("Please enter the Email  ID : ");
            string email = Console.ReadLine();
            bool val3 = Pattern.validateEmailID(email);

            if (val)
            {
                Console.WriteLine("First Name is Valid.");
            }
            else
            {
                Console.WriteLine("First Name is not Valid.");

            }

            if (val2)
            {
                Console.WriteLine("Last Name is Valid.");
            }
            else
            {
                Console.WriteLine("Last Name is not Valid.");

            }

            if (val3)
            {
                Console.WriteLine("Email ID is Valid.");
            }
            else
            {
                Console.WriteLine("Email ID is not Valid.");

            }
        }
    }
}
