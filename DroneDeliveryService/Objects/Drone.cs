using System;
using System.Collections.Generic;
using System.Text;

namespace DroneDeliveryService.Objects
{
    class Drone
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Drone(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
