using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Adrian";
            var lastName = "Fernandez";

            var fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0}, {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var text = @"Hi John
            Look inot the following paths
            c:\foler1\folder2
            c:folder3\foler4";
            Console.WriteLine(text);
        }
    }
}