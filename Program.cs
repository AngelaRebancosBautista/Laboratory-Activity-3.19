using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attendees = new List<string>();
            string input;

            Console.WriteLine("Enter names of students logging into the online class (type 'exit' to finish)");
            while (true)
            {
                Console.Write("Enter name: ");
                input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (!attendees.Contains(input))
                {
                    attendees.Add(input);
                    Console.WriteLine($"'{input}' logged in.");
                }
                else
                {
                    Console.WriteLine($"'{input}' has already logged in.");
                }
            }
            attendees.Sort();
            Console.WriteLine($"\nTotal unique attendees: {attendees.Count}");
            Console.WriteLine("Unique attendees:");
            foreach (var name in attendees)
            {
                Console.WriteLine(name);
            }
        }
    }
}
             
