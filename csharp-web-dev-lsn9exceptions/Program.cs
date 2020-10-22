using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if(y == 0.0)
            {
                throw new ArgumentOutOfRangeException("y", "Cannot divide by zero!");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            if(fileName == null || fileName == "")
            {
                throw new ArgumentNullException("fileName","File name is null.");
            } 
            else
            {
                if(fileName.Substring(fileName.Length-3,3) == ".cs")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Divide(1, 0);
            } 
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach(string student in students.Keys)
            {
                try
                {
                    Console.WriteLine(student);
                    Console.WriteLine(CheckFileExtension(students[student]));
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
            }



        }
    }
}
