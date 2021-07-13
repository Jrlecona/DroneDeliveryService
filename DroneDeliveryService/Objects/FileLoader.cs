using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DroneDeliveryService.Objects
{
    class FileLoader
    {
        public void ReadData(string fileName, out List<Drone> drones, out List<Location> locations)
        {

            drones = new List<Drone>();
            locations = new List<Location>();

            string[] lines = System.IO.File.ReadAllLines(fileName);

            //Get the first line with the Drones and set the list
            var auxDrones = lines[0].ToString().Split(",");
            for (int i = 0; i < auxDrones.Length; i += 2)
            {
                drones.Add(new Drone(auxDrones[i], Convert.ToInt32(auxDrones[i + 1])));
            }

            // Get all the locations and set the list
            lines = lines.Where((source, index) => index != 0).ToArray();
            foreach (string line in lines)
            {
                locations.Add(new Location(line.ToString().Split(",")[0], Convert.ToInt32(line.ToString().Split(",")[1])));
            }
        }
    }
}
