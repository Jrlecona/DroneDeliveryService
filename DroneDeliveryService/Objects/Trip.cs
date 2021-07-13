using System;
using System.Collections.Generic;
using System.Text;

namespace DroneDeliveryService.Objects
{
    class Trip
    {
        public List<Location> Locations { get; set; }

        public Trip(List<Location> locations)
        {
            Locations = locations;
        }
    }
}
