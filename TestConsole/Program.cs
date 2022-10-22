using System;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length > 0)
            {
                Console.WriteLine(GenerateRandomPassword(length));
            }
            
            Console.ReadLine();
             
        }

        public static string GenerateRandomPassword(int passwordLength)
        {
            System.Random rand = new System.Random();

            System.Text.StringBuilder passWord = new System.Text.StringBuilder();

            const string chars = "qwertyuiopasdfghjklzxcvbnm" +
                                 "QWERTYUIOPASDFGHJKLZXCVBNM" +
                                 "1234567890" +
                                 "<>?!@#$%^&*()";

            for (int i = 0; i < passwordLength; i++)
            {
                int index = rand.Next(chars.Length);
                passWord.Append(chars[index]);
            }
            return passWord.ToString();

        }
    }
}
