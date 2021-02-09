using System;

namespace ParkingManager
{
    public class Ticket
    {
        private Car _car;
        private DateTime _timeCreated;

        public Ticket(Car car)
        {
            _car = car;
            _timeCreated = DateTime.Now;
        }

        public DateTime Time
        {
            get { return _timeCreated; }
        }

        public Car Car
        {
            get { return _car; }
        }
    }
}