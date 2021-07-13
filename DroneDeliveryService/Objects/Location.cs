using System;
using System.Collections.Generic;
using System.Text;

namespace DroneDeliveryService.Objects
{
    class Location
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Location(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
