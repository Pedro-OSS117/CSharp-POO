using System;

namespace ParkingManager
{
    public class Parking
    {
        private Car[] _parkingSpaces;
        private float _oneHourPrice;
        private float _earnedMoney;

        public Parking(int nbrPlace, float price)
        {
            if (nbrPlace < 1)
            {
                nbrPlace = 1;
            }
            _parkingSpaces = new Car[nbrPlace];
            _earnedMoney = 0;

            if (price < 0)
            {
                price = 0;
            }
            _oneHourPrice = price;
        }

        public float EarnedMoney
        {
            get { return _earnedMoney; }
        }

        public int GetNbrSpaces()
        {
            return _parkingSpaces.Length;
        }

        private int FindFreeSpace()
        {
            for (int i = 0; i < _parkingSpaces.Length; i++)
            {
                if (_parkingSpaces[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddCar(Car car)
        {
            int index = FindFreeSpace();
            if (index != -1)
            {
                Console.WriteLine($"Thanks to park your car {car.OwnerName} !");
                _parkingSpaces[index] = car;
                return true;
            }
            Console.WriteLine("Sorry no space available - try later.");
            return false;
        }

        public void RemoveCar(Car car)
        {
            for (int i = 0; i < _parkingSpaces.Length; i++)
            {
                if (_parkingSpaces[i] == car)
                {
                    _parkingSpaces[i] = null;
                    return;
                }
            }
        }

        public int GetSpacesAvailable()
        {
            int nbrPlace = 0;
            for (int i = 0; i < _parkingSpaces.Length; i++)
            {
                if (_parkingSpaces[i] != null)
                {
                    nbrPlace++;
                }
            }
            return nbrPlace;
        }

        public float AddMoneyFromTime(DateTime time)
        {
            TimeSpan timeSpan = DateTime.Now.Subtract(time);
            float money = timeSpan.Hours * _oneHourPrice;
            money += timeSpan.Minutes / 60.0f * _oneHourPrice;
            _earnedMoney += money;
            return money;
        }

        public void DisplayParkingState()
        {
            for (int i = 0; i < _parkingSpaces.Length; i++)
            {
                string parkState = "Park n°" + (i + 1) + " : ";
                parkState += _parkingSpaces[i] != null ? _parkingSpaces[i].OwnerName : "None";
                Console.WriteLine(parkState);
            }
        }
    }
}