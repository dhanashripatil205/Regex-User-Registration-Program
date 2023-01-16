
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

            Console.WriteLine("Please enter the Mobile Number : ");
            string Monumber = Console.ReadLine();
            bool val4 = Pattern.validateMobileNumber(Monumber);

            Console.WriteLine("Please enter the Password : ");
            string password = Console.ReadLine();
            bool val5 = Pattern.validatePassword(password);

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

            if (val4)
            {
                Console.WriteLine("Mobile Number is Valid.");
            }
            else
            {
                Console.WriteLine("Mobile Number is not Valid.");

            }

            if (val5)
            {
                Console.WriteLine("Password is Correct.");
            }
            else
            {
                Console.WriteLine("Password is not Correct.");

            }
        }
    }
}
