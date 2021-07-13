using System;
using System.Collections.Generic;
using System.Text;

namespace DroneDeliveryService.Objects
{
    class Viewer
    {
        public void Display(List<Schedule> schedules)
        {
            var index = 1;

            foreach(Schedule schedule in schedules)
            {
                Console.WriteLine($"[Dron # {index++} {schedule.Drone.Name}]");
                var index1 = 1;
                foreach(Trip trip in schedule.Trips)
                {
                    Console.WriteLine($"Trip # {index1++}");
                    var index2 = 1;
                    foreach(Location location in trip.Locations)
                    {
                        Console.Write($"[Location #{index2++} {location.Name}], ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }
    }
}
