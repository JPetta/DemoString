using System;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Jovi";
            var lastName = "Petra";

            var fullname = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0}{1}", firstName, lastName);

            var names = new string[3] { "Jhonny", "Jenny", "Mark" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi jovi
                       Look into this
                            C:\folder1\folder2
                            C:\folder3\folder4";

                /*"Hi jovi\nLook into this\nC:\\folder1\\folder2\nC:\\folder3\\folder4";*/
            Console.WriteLine(text);

        }
    }
}
