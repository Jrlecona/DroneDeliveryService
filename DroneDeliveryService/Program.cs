using DroneDeliveryService.Objects;
using System;
using System.Collections.Generic;
using System.IO;

namespace DroneDeliveryService
{
    class Program
    {
        
        static void Main(string[] args)
        {
            FileLoader reader = new FileLoader();
            Scheduler scheduler = new Scheduler();
            Viewer viewer = new Viewer();

            reader.ReadData(@"C:\Users\jrlec\source\repos\DroneDeliveryService\DroneDeliveryService\Resources\data.txt", out List<Drone> drones, out List<Location> locations);
            viewer.Display(scheduler.GenerateSchedule(drones, locations));
        }
    }
}
