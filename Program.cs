// Needed for using any Cryptography class like SHA256
using System.Security.Cryptography;
// Needed for using Encoding
using System.Text;

namespace hashPassword {
    public class Program {
        static void Main(string[] args) {

            int amount = 0;

            for (int i = 0; i < 3; i++) {

                int a = i;
                string password = Convert.ToString(a);
                string hashedPassword = hashPassword(password);
                Console.WriteLine(hashedPassword);
                amount++;
            }
            Console.WriteLine($"\ntotal amount lines = {amount}\n");

            string example = "jabadabadoe";
            string hashed = hashPassword(example);
            Console.WriteLine(hashed);


        }

        public static string hashPassword(string password) {

            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            byte[] hashedPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashedPassword);
        }
    }
}