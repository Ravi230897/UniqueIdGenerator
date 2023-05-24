using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueIdGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //write a program to generate 15000 unique and random id (should be alphanumeric).
            // Length should be  20 characters
            int numberOfIds = 15000;
            int idLength = 20;

            List<string> uniqueIds = GenerateUniqueIds(numberOfIds, idLength);

            Console.WriteLine("Generated unique IDs:");
            foreach (string id in uniqueIds)
            {
                Console.WriteLine(id);
                Console.ReadLine();
            }
        }

        public static List<string> GenerateUniqueIds(int numberOfIds, int idLength)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            HashSet<string> uniqueIds = new HashSet<string>();

            while (uniqueIds.Count < numberOfIds)
            {
                string id = new string(Enumerable.Repeat(chars, idLength)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                uniqueIds.Add(id);
            }

            return uniqueIds.ToList();
        }
    }
}
