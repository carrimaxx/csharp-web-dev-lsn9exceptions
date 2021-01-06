using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
                throw new ArgumentOutOfRangeException("Cannot divide by zero");
            else
                return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            int points = 0;
            if (fileName == null || fileName == "")
            {
                throw new ArgumentException("Invalid input, filename is either null or empty");
            }
            else if(fileName.EndsWith(".cs") == true)
            {
                points++;
            }
           
            return points;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                double result = Program.Divide(7,0);
                Console.WriteLine(result);
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    int test = Program.CheckFileExtension(student.Value);
                    Console.WriteLine(student.Key + ": " + test);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(student.Key + ": {0}", e.Message);
                }
            }
        }
    }
}
