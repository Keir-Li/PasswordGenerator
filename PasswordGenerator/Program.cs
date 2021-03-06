using System;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize Variables
            int passwordLengthMin = 5;
            int passwordLengthMax = 100000;
            int passwordLength = 0;
            bool infLoop = true;


            // Operning Text
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Password Generator");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");

            // Infinite Loop over the Program
            while (infLoop == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter a password length you'd like.");
                Console.WriteLine("MIN: 5 characters");
                Console.WriteLine("MAX: 100,000 characters");
                passwordLength = int.Parse(Console.ReadLine());

                // Password Min & Max Length Validation
                if (passwordLength < passwordLengthMin || passwordLength > passwordLengthMax)
                {
                    Console.WriteLine("");
                    Console.WriteLine("ATTENTION!");
                    Console.WriteLine("Length must be atleast 5 & less than 100,000 characters.");
                }
                else
                {
                    Console.WriteLine("");
                    var password = Password.Generate(passwordLength);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Generated Password: " + password);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

            }
        }

    }
}
