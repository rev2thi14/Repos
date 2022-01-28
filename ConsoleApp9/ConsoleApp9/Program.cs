using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome to CSharp corner";
            string strrev = "";

            foreach (var word in str.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp + "";
            }
            Console.WriteLine(strrev);
        }
    }
    }
    
           

              
            
        
        
    

