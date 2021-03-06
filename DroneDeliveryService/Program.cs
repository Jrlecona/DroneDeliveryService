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

            string fileName = "data.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"Resources\", fileName);

            reader.ReadData(path, out List<Drone> drones, out List<Location> locations);
            viewer.Display(scheduler.GenerateSchedule(drones, locations));
        }
    }
}
