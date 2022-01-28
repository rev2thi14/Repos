using System;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[12];
            for (i = 0; i < 12; i++)
            {
                Console.Write("\nEnter your id:\t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter your Source:\t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nDestination:\t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter your Date:\t");
                Console.ReadLine();
                Console.Write("\nEnter your Status:\t");
                Console.ReadLine();
                Console.Write("\nEnter your Network:\t");
                Console.ReadLine();
            }
            Console.WriteLine("/n/n");
                string path = "E:\\Capgemini\\networkLog.txt";
                FileStream filestreamObj = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(filestreamObj);
                Console.WriteLine("id    " + "Source     " + "Destination    " + "Date    " + "Status    " + "Network");
                while (sr.Peek() > 0)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(':');
                    if (line != "")
                    {
                        if (values.Length > 1)
                        {
                            Console.Write(values[1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                }
            }
        }
    }


        
