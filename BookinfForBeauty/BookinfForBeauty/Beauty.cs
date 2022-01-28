using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookinfForBeauty
{
    class Beauty

    {
        static void Main(string[] args)
        {
            List<string> AppointmentSchedule = new List<string>();
            AppointmentSchedule.Add("7/25/2019 13:45:00");
            foreach (var p in AppointmentSchedule)
            {
                Console.WriteLine(p);
                Console.ReadLine();
            }
            {
                List<string> Appointmenthaspassed = new List<string>();
                Appointmenthaspassed.Add("7/25/2019 13:45:00");
                foreach (var p in Appointmenthaspassed)
                {
                    Console.WriteLine(Appointmenthaspassed.Contains("7/25/2019 13:45:00"));
                    Console.ReadLine();
                }
                {
                    List<string> Appointmentinafternoon = new List<string>();
                    Appointmentinafternoon.Add("7/25/2019 13:45:00");
                    TimeSpan start = new TimeSpan(12, 0, 0);
                    TimeSpan end = new TimeSpan(18, 0, 0);
                    if (start <= end)
                    {
                        Console.WriteLine("ppointment is booked in Appointmentinafternoon");
                        foreach (var i in Appointmentinafternoon)
                        {
                            Console.WriteLine(Appointmentinafternoon.Contains(i));
                            Console.ReadLine();
                        }
                    }
                    List<string> Description = new List<string>();
                    Description.Add("7/25/2019 13:45:00");
                    foreach (var d in Description)
                    {
                        Console.WriteLine("you have an appointment on {0}", d);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
    
        
                
