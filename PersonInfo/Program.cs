using System;
using System.IO;

namespace PersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Test.txt");

                Console.WriteLine("What is your First Name?");
                var firstname = Console.ReadLine();
                sw.WriteLine("Your first name is:{0}",firstname);

                Console.WriteLine("What is your Last Name?");
                var lastname = Console.ReadLine();
                sw.WriteLine("Your last name is:{0}",lastname);

                sw.Close();
                // Read the file as one string.
                string text = System.IO.File.ReadAllText(@"C:\\Test.txt");

                // Display the file contents to the console. Variable text is a string.
                System.Console.WriteLine(text);



            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
