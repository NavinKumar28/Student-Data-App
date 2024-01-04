using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataViewer
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
          
            string filePath = "C:\\Users\\Navin\\source\\repos\\students.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                // Display student data
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found!");
            }

            Console.ReadLine();
        }
    }

}
