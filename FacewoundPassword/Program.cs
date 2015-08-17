using System;

namespace FacewoundPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Local HWID Calculated as: " + Classes.MachineIdentification.Value());

            Console.WriteLine("Please enter a password to use:");
            string password = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Your encrypted string is:");
            string encryptedstring = Classes.Crypto.Encrypt(password);
            Console.WriteLine(encryptedstring);
            Console.WriteLine("");

            Console.WriteLine("Your decrypted string is:");
            string decryptedstring = Classes.Crypto.Decrypt(encryptedstring);
            Console.WriteLine(decryptedstring);
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
