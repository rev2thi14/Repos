using System;


namespace FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = @"D:\csharp\example.txt";
                //Creating File
                FileStream fs = new FileStream(file, FileMode.Create);
                //Adding current date and time in file
                byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());
                fs.Write(bdata, 0, bdata.Length);
                Console.WriteLine("Data Added");
                fs.Close();
                //Reading File
                string data;
                FileStream fsread = new FileStream(file, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fsread))
                {
                    data = sr.ReadToEnd();
                }
                Console.WriteLine(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            Console.ReadKey();
        }
    }
}
