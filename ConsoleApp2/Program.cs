using System;
public class Exercise1
{
   public static void Main()
    {
        int[] arr = new int[10];
        int i;
            Console.WriteLine("\n\nread and print elements of an array:\n");
        Console.Write("----------------------------\n");
        
 
            Console.Write("input 10 elements in the array:\n");
            for (i = 0; i < 10; i++)
            {
            Console.Write("element-{0}:", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("\nelements in array are:");
        for (i = 0; i < 10; i++)
        {
            Console.Write("{0}", arr[i]);
        }
        Console.Write("\n");
    }
}
