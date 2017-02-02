using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Name:  > ");
                student.name[i] = Console.ReadLine();

                Console.Write("Student ID:  > ");
                student.studentID[i] = Console.ReadLine();

                Console.Write("Year:  > ");
                string line1 = Console.ReadLine();
                student.year[i] = int.Parse(line1);
            }
            for (int i = 0; i <= 4; i++)
                Console.WriteLine("Student: " + student.name[i] + " Student ID: " + student.studentID[i] + " Year: " + student.year[i]);
        }
    }
}