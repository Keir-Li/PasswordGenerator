using System;

namespace PasswordGenerator
{
    public class Password
    {

        public static string Generate(int passwordLength)
        {
            // Password variables
            string lowercaseLetters = "qwertyuiopasdfghjklzxcvbnm";
            string capitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string numbers = "0123456789";
            string specialCharacters = "!@#$%^&*()-_=+<>";
            string allCharacters = lowercaseLetters + capitalLetters + numbers + specialCharacters;
            string generatedPassword = "";

            // New random number generator instance
            Random newCharacter = new Random();

            // Loop for the password length, each character to be random
            for (int i = 0; i < passwordLength; i++)
            {
                int randomNumber = newCharacter.Next(0, allCharacters.Length);
                generatedPassword += allCharacters[randomNumber];
            }

            return generatedPassword;

        }
    }
}
