using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19RejexAssignment
{
    public class Pattern
    {
        public static string Reg_pattern1 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern2 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern3 = "^(abc)(.[A-Za-z]+)*@(bl).(co)([.][a-z]{2,})?$";
        public static string Reg_pattern4 = "^[0-9]{2}\\s[0-9]{10}$";
        public static string Reg_pattern5 = "^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).*$";


        public static bool validateName(string name)
        {
            return Regex.IsMatch(name, Reg_pattern1);

        }
        public static bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, Reg_pattern2);
        }

        public static bool validateEmailID(string email)
        {
            return Regex.IsMatch(email, Reg_pattern3);
        }
        public static bool validateMobileNumber(string Monumber)
        {
            return Regex.IsMatch(Monumber, Reg_pattern4);

        }

        public static bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Reg_pattern5);

        }

    }
}
