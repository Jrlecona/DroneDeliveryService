using System;
using System.Collections.Generic;
using System.Text;

namespace DroneDeliveryService.Objects
{
    class Schedule
    {
        public Drone Drone { get; set; }
        public List<Trip> Trips { get; set; }

        public Schedule(Drone drone, List<Trip> trips)
        {
            Drone = drone;
            Trips = trips;
        }

    }
}
