using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class Doctor
    {
        public void CreateDoctorFile()
        {
            //step1 file creation
            FileStream filestreamobj = new FileStream("E:\\Capgemini\\myfile.txt", FileMode.Create, FileAcess, Write);
            //Step2 write operation
            StreamWriter sw = new StreamWriter(filestreamobj);
            sw.Writeline("Welcome");
            Console.WriteLine("please fill the details below...\n");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Category:");
            string category = Console.ReadLine();
            Console.Write("Experience:");
            string Experience = Console.ReadLine();
            Console.Write("Address:");
            string Address = Console.ReadLine();
            sw.Close();
            filestreamobj.Close();
            Console.WriteLine("Doctor details saved syccessfully in the file");
        }
        
       }
    }
}
