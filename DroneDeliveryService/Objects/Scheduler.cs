using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DroneDeliveryService.Objects
{
    class Scheduler
    {
        public List<Schedule> GenerateSchedule(List<Drone> drones, List<Location> locations)
        {
            List<Schedule> schedules = new List<Schedule>();
            var remainingLocations = locations;
            foreach(Drone drone in drones)
            {
                List<Trip> tripsDrone = GetScheduledTripsDrone(drone, schedules);
                List<Location> locationsChoosed = LocationsChosenByCapacity(drone.Weight, remainingLocations);

                if (locationsChoosed.Count > 0)
                {

                    remainingLocations.RemoveAll(location =>
                    {
                        return locationsChoosed.Any(choosed => choosed == location);
                    });
                    //remainingLocations = (List<Location>)remainingLocations.Where(
                    //    location => locationsChoosed.All(choosed => choosed.Name != location.Name));

                    tripsDrone.Add(new Trip(locationsChoosed));
                }
                schedules.Add(new Schedule(drone, tripsDrone));
            }
            
            return schedules;
        }

        public List<Trip> GetScheduledTripsDrone(Drone drone, List<Schedule> schedule)
        {
            foreach(Schedule droneSchedule in schedule)
            {
                return (droneSchedule.Drone == drone) ? droneSchedule.Trips : new List<Trip>();
            }

            return new List<Trip>();
        }

        public List<Location> LocationsChosenByCapacity(int capacity, List<Location> locations)
        {
            List<Location> locationsSelected = new List<Location>();
            foreach(var location in locations)
            {
                var totalLoad = CalculateLoad(locationsSelected);
                var capacityLeft = capacity - totalLoad;
                if(location.Weight < capacityLeft && locations.Count > 1)
                {
                    locations.RemoveAt(0);
                    var found = LocationsChosenByCapacity(capacityLeft - location.Weight, locations);

                    if (found.Count > 0)
                    {
                       found.Add(location);
                       return locationsSelected.Concat(found).ToList();
                    }
                }
                else if (location.Weight >= capacityLeft)
                {
                    locationsSelected.Add(location);
                    return locationsSelected;
                }
                return locationsSelected;
            }
            return locationsSelected;
        }

        public int CalculateLoad(List<Location> locations)
        {
            int load = 0;

            foreach(var location in locations)
            {
                load += location.Weight;
            }

            return load;
        }
    }
}
