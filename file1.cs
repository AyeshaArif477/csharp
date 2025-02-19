using System;
using System.Text.RegularExpressions;

public class PasswordChecker
{
    public static void Main()
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        // Updated regex pattern
        string pattern = @"^(?=.*[A-Z])" +           // At least 1 uppercase
                         @"(?=.*[!@#$%^&*].*[!@#$%^&*])" +  // At least 2 special characters
                         @"(?=.*\d.*\d)" +           // At least 2 digits
                         @"(?=.*[a-z].*[a-z].*[a-z].*[a-z])" +  // At least 4 lowercase letters
                         @"[A-Za-z0-9!@#$%^&*]{1,12}$"; // Up to 12 chars total

        Regex regex = new Regex(pattern);

        if (regex.IsMatch(password))
        {
            Console.WriteLine("Password is valid!");
        }
        else
        {
            Console.WriteLine("Password is invalid!");
        }
    }
}
